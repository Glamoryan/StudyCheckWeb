using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Concrete.EntityFramework.Contexts;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Sign.Controllers
{
    [Area("Sign")]
    public class RegisterController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        private IUyeService _uyeService;
        private IUyedetayService _uyedetayService;

        public RegisterController(UserManager<User> userManager, SignInManager<User> signInManager, IUyeService uyeService, IUyedetayService uyedetayService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _uyeService = uyeService;
            _uyedetayService = uyedetayService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string ad, string soyad, string kullaniciAdi, string sifre, string email)
        {
            try
            {
                if (ad == null || soyad == null)
                    throw new RequiredFieldsException("Ad/Soyad boş bırakılamaz!");
                else if (kullaniciAdi == null)
                    throw new RequiredFieldsException("Kullanıcı adı boş bırakılamaz!");
                else if (sifre == null)
                    throw new RequiredFieldsException("Şifre boş bırakılamaz!");

                if (await _userManager.FindByNameAsync(kullaniciAdi) != null || await _userManager.FindByEmailAsync(email) != null)//veri asp.users tablosunda var mı
                    throw new Exception("Bu kullanıcı zaten mevcut");//var
                else//yok
                {
                    var kullanici = _uyedetayService.GetAll().Where(k => k.kullanici_adi == kullaniciAdi || k.kullanici_mail == email).FirstOrDefault();//veri uyedetay tablosunda var mı                    
                    if (kullanici != null)//var
                    {
                        throw new Exception("Bu kullanıcı bilgileri masaüstü uygulamasında zaten mevcut. Bu kullanıcı ile Giriş yapmayı deneyin yada farklı bilgiler ile kayıt olun!");
                    }
                    else //yok
                    {
                        using (StudyCheckContext context = new StudyCheckContext())
                        {
                            using (var transaction = context.Database.BeginTransaction())//transaction'a başla ve tabloları kilitle
                            {
                                try
                                {
                                    Uye uyemiz = new Uye
                                    {
                                        uye_ad = ad,
                                        uye_soyad = soyad
                                    };
                                    Uye createdUye = context.Uyeler.Add(uyemiz).Entity;
                                    context.SaveChanges();
                                    Uyedetay kullanicimiz = new Uyedetay
                                    {
                                        uye_id = createdUye.id,
                                        kullanici_adi = kullaniciAdi,
                                        kullanici_sifre = sifre,
                                        kullanici_mail = email,
                                        guncelleyen_id = 1,
                                        guncelleme_tarihi = DateTime.Now,
                                        kayit_tarihi = DateTime.Now,
                                        rol_id = 1,
                                        sil_id = 1,
                                        tema_id = 1
                                    };
                                    var createdUyedetay = context.UyeDetay.Add(kullanicimiz).Entity;
                                    context.SaveChanges();
                                    User createdLogin = new User
                                    {
                                        kullaniciAdi = kullaniciAdi,
                                        kullaniciSifre = sifre,
                                        kullaniciMail = email,
                                        uyeAdi = ad,
                                        uyeSoyadi = soyad,
                                        rolId = 1,
                                        uyeId = createdUye.id,
                                        uyeDetayId = createdUyedetay.id,
                                        UserName = kullaniciAdi,
                                        Email = email,
                                        PasswordHash = sifre
                                    };
                                    IdentityResult createResult = await _userManager.CreateAsync(createdLogin, sifre);
                                    if (createResult.Succeeded)
                                    {
                                        ViewBag.IdentityResult = "Kullanıcı başarıyla oluşturuldu";
                                    }
                                    else
                                    {
                                        ViewBag.IdentityErrors = createResult;
                                        throw new Exception("Hata! İşlem iptal edildi");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();//değişiklikleri geri al
                                    throw new Exception(ex.Message);
                                }
                                transaction.Commit();//tablo kilitlerini aç
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message; //red
            }
            return View();
        }
    }
}