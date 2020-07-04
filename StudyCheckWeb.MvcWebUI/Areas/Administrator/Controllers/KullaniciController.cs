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
        SenkronizasyonModel _model;

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
        
        public IActionResult KullaniciDuzenle(KullaniciModel model)
        {
            model.tumRoller = _rolService.GetListByStatus(1);
            model.guncelleyenKisi = _uyedetayService.GetById(model.guncelleyenId).kullanici_adi;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> KullaniciDuzenle(string uyeDetayId,string uyeId,string kayitTarihi,string kullaniciAdi, string sifre, string mail, int durum, int rol, string uyeAd, string uyeSoyad)
        {
            try
            {
                if (uyeAd == null || uyeSoyad == null)
                    throw new RequiredFieldsException("Üye bilgileri boş bırakılamaz!");
                else if (kullaniciAdi == null || sifre == null || mail == null)
                    throw new RequiredFieldsException("Kullanıcı bilgileri boş bırakılamaz!");
                var kullanici = _uyedetayService.GetAll().Where(k => k.kullanici_adi == kullaniciAdi || k.kullanici_mail == mail).ToList();
                if (kullanici.Count > 1)
                    throw new Exception("Bu kullanıcı adı / mail zaten mevcut!");
                else
                {
                    using (StudyCheckContext context = new StudyCheckContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                var oldUser = _uyedetayService.GetById(Convert.ToInt32(uyeDetayId));
                                var updatedUser =await _userManager.FindByNameAsync(oldUser.kullanici_adi);
                                IdentityResult passResult = await _userManager.ChangePasswordAsync(updatedUser, oldUser.kullanici_sifre, sifre);
                                if(!passResult.Succeeded)
                                    throw new Exception(passResult.ToString());
                                
                                updatedUser.UserName = kullaniciAdi;
                                updatedUser.NormalizedUserName = kullaniciAdi.ToUpper();
                                updatedUser.Email = mail;
                                updatedUser.NormalizedEmail = mail.ToUpper();
                                updatedUser.uyeAdi = uyeAd;
                                updatedUser.uyeSoyadi = uyeSoyad;
                                updatedUser.kullaniciAdi = kullaniciAdi;
                                updatedUser.kullaniciSifre = sifre;
                                updatedUser.kullaniciMail = mail;
                                updatedUser.rolId = rol;                                
                                IdentityResult result = await _userManager.UpdateAsync(updatedUser);
                                if (!result.Succeeded)
                                    throw new Exception(result.ToString());
                                else
                                {
                                    Uye updatedUye = new Uye
                                    {
                                        id = Convert.ToInt32(uyeId),
                                        uye_ad = uyeAd,
                                        uye_soyad = uyeSoyad
                                    };
                                    context.Uyeler.Update(updatedUye);
                                    context.SaveChanges();
                                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                                    Uyedetay updatedKullanici = new Uyedetay
                                    {
                                        id = Convert.ToInt32(uyeDetayId),
                                        kullanici_adi = kullaniciAdi,
                                        kullanici_sifre = sifre,
                                        kullanici_mail = mail,
                                        kayit_tarihi = Convert.ToDateTime(kayitTarihi),
                                        guncelleyen_id = identityUser.uyeDetayId,
                                        guncelleme_tarihi = DateTime.Now,
                                        uye_id = Convert.ToInt32(uyeId),
                                        rol_id = rol,
                                        tema_id = 1,
                                        sil_id = durum
                                    };
                                    context.UyeDetay.Update(updatedKullanici);
                                    context.SaveChanges();
                                }
                                
                            }
                            catch (Exception transException)
                            {
                                transaction.Rollback();
                                throw new Exception(transException.Message);
                            }
                            ViewBag.Message = "Kullanıcı güncellendi";
                            transaction.Commit();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            return RedirectToAction("KullaniciListesi");
        }

        public async Task<IActionResult> KullaniciListesi()
        {
            var userDetails = _uyeService.GetAllUserDetail();            
            _entityListModel = new EntityListModel
            {
                UserDetails = userDetails,
                roller = _rolService.GetAll(),
                senkron = new List<SenkronizasyonModel>()
            };            
            foreach (var user in userDetails)
            {
                var identity = await _userManager.FindByNameAsync(user.kullanici_adi);
                if (identity == null)
                {
                    _model = new SenkronizasyonModel
                    {
                        senkronUsername = user.kullanici_adi,
                        senkron = 0
                    };
                    _entityListModel.senkron.Add(_model);
                }
                else
                {
                    _model = new SenkronizasyonModel
                    {
                        senkronUsername = user.kullanici_adi,
                        senkron = 1
                    };
                    _entityListModel.senkron.Add(_model);
                }
            }
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