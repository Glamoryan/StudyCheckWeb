using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
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
            return View();
        }

        /// <summary>
        /// Kullanıcı identity'nin users tablosunda var mı?
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <returns></returns>
        public async Task<bool> userExist(string kullaniciAdi)
        {
            var user = await _userManager.FindByNameAsync(kullaniciAdi);
            if (user != null)
                return true;
            return false;
        }

        [HttpPost]
        public async Task<IActionResult> Index(string kullaniciAdi, string sifre)
        {
            try
            {
                if (kullaniciAdi == null || sifre == null)
                    throw new RequiredFieldsException("Kullanıcı Adı / Şifre boş bırakılamaz!");

                //Bilgiler asp.users tablosunda varmı 
                if(await _userManager.FindByNameAsync(kullaniciAdi) != null)
                {
                    var loginResult = await _signInManager.PasswordSignInAsync(kullaniciAdi, sifre, false, false);
                    if (loginResult.Succeeded)//var
                        return RedirectToAction("Index", "dashboard", new { area = "administrator" });
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
                            throw new Exception("Web versiyonu için bilgilerinizi güncelleyin!!!");
                        }
                        else if (identityResult.Succeeded)//success
                        {
                            AccountInfosModel model = new AccountInfosModel
                            {
                                KullaniciBilgisi = new UserDetail
                                {
                                    uye_ad = createUser.uyeAdi,
                                    uye_soyad = createUser.uyeSoyadi,
                                    kullanici_adi = createUser.kullaniciAdi,
                                    kullanici_sifre = createUser.kullaniciSifre,
                                    kullanici_mail = createUser.kullaniciMail,
                                    uye_id = user.uye_id,
                                    guncelleme_tarihi = user.guncelleme_tarihi,
                                    guncelleyen_id = user.guncelleyen_id,
                                    kayit_tarihi = user.kayit_tarihi,
                                    rol_id = user.rol_id,
                                    sil_id = user.sil_id,
                                    tema_id = user.tema_id,
                                    uyedetay_id = user.id
                                }
                            };
                            TempData["kullaniciModel"] = model;
                            var newLoginResult = await _signInManager.PasswordSignInAsync(createUser, createUser.kullaniciSifre, false, false);
                            if (newLoginResult.Succeeded)
                                return RedirectToAction("Index", "Dashboard",new {area="administrator");
                            else
                            {
                                ViewBag.Exceptions = newLoginResult;
                                throw new Exception("Hata");
                            }                                
                        }                        
                    }
                    else //veri uyedetayTablosunda yoksa
                    {                        
                        throw new Exception("Bilgilerinizi kontrol edin veya Yeni kullanıcı oluşturun");
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