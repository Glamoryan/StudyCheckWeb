using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.DataAccess.Concrete.EntityFramework.Contexts;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class KullaniciController : Controller
    {
        IUyeService _uyeService;
        IRolService _rolService;
        IUyedetayService _uyedetayService;
        UserManager<User> _userManager;
        EntityListModel _entityListModel;

        public KullaniciController(IUyeService uyeService, IRolService rolService, IUyedetayService uyedetayService, UserManager<User> userManager)
        {
            _uyeService = uyeService;
            _rolService = rolService;
            _uyedetayService = uyedetayService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KullaniciListesi()
        {
            _entityListModel = new EntityListModel
            {
                UserDetails = _uyeService.GetAllUserDetail(),
                roller = _rolService.GetAll()
            };
            return View(_entityListModel);
        }
        public IActionResult KullaniciEkle()
        {
            _entityListModel = new EntityListModel
            {
                roller = _rolService.GetListByStatus(1)
            };
            return View(_entityListModel);
        }

        [HttpPost]
        public async Task<IActionResult> KullaniciEkle(string kullaniciAdi,string sifre,string mail,int durum,int rol,string uyeAd,string uyeSoyad)
        {
            try
            {
                if (kullaniciAdi == null || sifre == null || mail == null)
                    throw new RequiredFieldsException("Kullanıcı bilgileri boş bırakılamaz!");
                else if (uyeAd == null || uyeSoyad == null)
                    throw new RequiredFieldsException("Üye bilgileri boş bırakılamaz!");

                var user = _uyedetayService.GetAll().Where(k => k.kullanici_adi == kullaniciAdi || k.kullanici_mail == mail).FirstOrDefault();//uyedetay tablosunda var mı
                if (user != null)//var
                    throw new Exception("Bu kullanıcı adı / mail zaten mevcut!");
                else //yok
                {
                    using (StudyCheckContext context = new StudyCheckContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                Uye uyemiz = new Uye
                                {
                                    uye_ad = uyeAd,
                                    uye_soyad = uyeSoyad
                                };
                                Uye createdUye = context.Uyeler.Add(uyemiz).Entity;
                                context.SaveChanges();
                                var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                                Uyedetay kullanicimiz = new Uyedetay
                                {
                                    uye_id = createdUye.id,
                                    kullanici_adi = kullaniciAdi,
                                    kullanici_sifre = sifre,
                                    kullanici_mail = mail,
                                    kayit_tarihi = DateTime.Now,
                                    guncelleme_tarihi = DateTime.Now,
                                    sil_id = durum,
                                    tema_id = 1,
                                    rol_id = rol,
                                    guncelleyen_id = identityUser.uyeDetayId
                                };
                                var createdKullanici = context.UyeDetay.Add(kullanicimiz).Entity;
                                context.SaveChanges();                                
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception(ex.Message);
                            }
                            ViewBag.Message = "Kullanıcı Oluşturuldu";
                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            _entityListModel = new EntityListModel
            {
                roller = _rolService.GetListByStatus(1)
            };
            return View(_entityListModel);

        }
    }
}