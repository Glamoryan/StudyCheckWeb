using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Business.Concrete;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Sign.Controllers
{
    [Area("Sign")]    
    public class LoginController : Controller
    {
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;
        private IUyeService _uyeService;
        private IUyedetayService _uyedetayService;

        public LoginController(SignInManager<User> signInManager, UserManager<User> userManager, IUyeService uyeService, IUyedetayService uyedetayService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _uyeService = uyeService;
            _uyedetayService = uyedetayService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if(User.IsInRole("Admin"))
                    return RedirectToAction("Index", "Dashboard", new {area = "administrator" });
                else if (User.IsInRole("User"))
                    return RedirectToAction("Index", "Home", new { area = "Study" });
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string kullaniciAdi, string sifre)
        {
            try
            {
                if (kullaniciAdi == null || sifre == null)
                    throw new RequiredFieldsException("Kullanıcı Adı / Şifre boş bırakılamaz!");

                //Bilgiler asp.users tablosunda varmı 
                var loggedUser = await _userManager.FindByNameAsync(kullaniciAdi);
                if (loggedUser != null)//var
                {                                      
                    var loginResult = await _signInManager.PasswordSignInAsync(kullaniciAdi, sifre, false, false);
                    if (loginResult.Succeeded)//bilgiler dogrumu
                    {
                        if(await _userManager.IsInRoleAsync(loggedUser, "Admin"))//Admin paneli
                        {
                            return RedirectToAction("Index", "dashboard", new { area = "administrator", kullaniciId = loggedUser.uyeDetayId });
                        }
                        else //Kullanıcı Sayfası
                        {
                            return RedirectToAction("Index", "Home", new { area = "Study" });
                        }
                    }                        
                    else
                        throw new Exception("Kullanıcı bilgileri hatalı");
                }               
                else //yok
                {
                    //Bilgiler uyedetayTablosunda varmı
                    var user = _uyedetayService.GetAll().Where(k => k.kullanici_adi == kullaniciAdi && k.kullanici_sifre == sifre).FirstOrDefault();
                    if (user != null)//var
                    {
                        Uye uye = _uyeService.GetById(user.uye_id);
                        User createUser = new User
                        {
                            uyeId = uye.id,
                            uyeDetayId = user.id,
                            uyeAdi = uye.uye_ad,
                            uyeSoyadi = uye.uye_soyad,
                            kullaniciAdi = user.kullanici_adi,
                            kullaniciSifre = user.kullanici_sifre,
                            kullaniciMail = user.kullanici_mail,
                            UserName = user.kullanici_adi,
                            PasswordHash = user.kullanici_sifre,
                            Email = user.kullanici_mail,
                            rolId = user.rol_id
                        };
                        IdentityResult identityResult = await _userManager.CreateAsync(createUser, createUser.kullaniciSifre);
                        if (!identityResult.Succeeded)//failed
                        {
                            ViewBag.IdentityResult = identityResult;
                            throw new Exception("Hesabınız bulundu fakat web versiyonu için hesap bilgileri güncellenmeli! (Code:21) (Yardım)");
                        }
                        else if (identityResult.Succeeded)//success
                        {                            
                            var newLoginResult = await _signInManager.PasswordSignInAsync(createUser, createUser.kullaniciSifre, false, false);
                            if (newLoginResult.Succeeded)
                                ViewBag.Warning = "Hesabınız senkronize edildi fakat giriş yapabilmek için onaylanmasını bekleyin(Code:06)";
                            else
                            {
                                ViewBag.Exceptions = newLoginResult;
                                throw new Exception("Hata");
                            }                                
                        }                        
                    }
                    else //veri uyedetayTablosunda yoksa
                    {                        
                        throw new Exception("Kullanıcı bulunamadı! Bilgilerinizi kontrol edin veya Yeni kullanıcı oluşturun");
                    }                                     
                }
            }            
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            return View();
        }

        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/sign");
        }
    }
}