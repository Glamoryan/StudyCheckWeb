using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Sign.Controllers
{
    [Area("Sign")]
    public class RegisterController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public RegisterController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string ad,string soyad,string kullaniciAdi,string sifre,string email)
        { 
            try
            {
                if (ad == null || soyad == null)
                    throw new RequiredFieldsException("Ad/Soyad boş bırakılamaz!");

                User user = await _userManager.FindByNameAsync(kullaniciAdi);
                if(user == null)
                {
                    user = new User
                    {
                        uyeAdi = ad,
                        uyeSoyadi = soyad,
                        kullaniciAdi = kullaniciAdi,
                        kullaniciSifre = sifre,
                        kullaniciMail = email,
                        UserName = kullaniciAdi,
                        PasswordHash = sifre,
                        Email = email,
                        rolId=1
                    };
                    IdentityResult result = await _userManager.CreateAsync(user, sifre);
                    if (result.Succeeded)
                        ViewBag.Message = "Kullanıcı oluşturuldu";
                    else
                        ViewBag.Message = result.Errors;
                }
                else
                {
                    ViewBag.Message = "Bu Kullanıcı Adı zaten kayıtlı";
                }
            }
            catch (RequiredFieldsException rqEx)
            {
                ViewBag.Exceptions = rqEx.Message; //red
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message; //red
            }
            return View();
        }
    }
}