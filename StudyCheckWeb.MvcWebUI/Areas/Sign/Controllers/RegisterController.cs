using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
                ViewBag.Message = "Kullanıcı zaten kayıtlı";

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
                        Email = email
                    };
                    IdentityResult result = await _userManager.CreateAsync(user, sifre);
                    ViewBag.Message = "Kullanıcı oluşturuldu";

                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();
        }
    }
}