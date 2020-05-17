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
    public class LoginController : Controller
    {
        private SignInManager<User> _signInManager;        

        public LoginController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {           
            return View();           
        }

        [HttpPost]
        public async Task<IActionResult> Index(string kullaniciAdi,string sifre)
        {
            try
            {
                if (kullaniciAdi == null || sifre == null)
                    throw new RequiredFieldsException("Kullanıcı Adı / Şifre boş bırakılamaz!");
                var result = await _signInManager.PasswordSignInAsync(kullaniciAdi, sifre, false, false);
                if (result.Succeeded)
                    return Redirect("/panel");               
                else
                    ViewBag.Result = "Kullanıcı Adı veya Şifre geçersiz";
            }
            catch (RequiredFieldsException reqEx)
            {
                ViewBag.Exceptions = reqEx.Message;
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