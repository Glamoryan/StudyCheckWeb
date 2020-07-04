using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class DersController : Controller
    {
        IDersService _dersService;
        ISinavService _sinavService;
        IUyedetayService _uyedetayService;
        EntityListModel _entityListModel;
        UserManager<User> _userManager;

        public DersController(IDersService dersService, ISinavService sinavService, IUyedetayService uyedetayService, UserManager<User> userManager)
        {
            _dersService = dersService;
            _sinavService = sinavService;
            _uyedetayService = uyedetayService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DersDuzenle(DersModel model)
        {
            model.tumSinavlar = _sinavService.GetListByStatus(1);
            model.ekleyenKisi = _uyedetayService.GetById(model.ekleyenId).kullanici_adi;
            model.guncelleyenKisi = _uyedetayService.GetById(model.guncelleyenId).kullanici_adi;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DersDuzenle(string dersAd,int durum,int sinavId,int dersId,string kayitTarihi,int ekleyenId)
        {
            try
            {
                if (dersAd == null)
                    throw new RequiredFieldsException("Ders adı boş bırakılamaz");
                var dersler = _dersService.GetAll().Where(d => d.ders_ad == dersAd).ToList();
                if (dersler.Count > 1)
                    throw new Exception("Bu ders zaten kayıtlı");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Ders updatedDers = new Ders
                    {
                        id = dersId,
                        ders_ad = dersAd,
                        eklenme_tarihi = Convert.ToDateTime(kayitTarihi),
                        ekleyen_id = ekleyenId,
                        guncelleme_tarihi = DateTime.Now,
                        guncelleyen_id = identityUser.uyeDetayId,
                        sil_id = durum,
                        sinav_id = sinavId
                    };
                    _dersService.UpdateDers(updatedDers);
                    TempData["Sonuc"] = "Ders başarıyla güncellendi";
                }
            }
            catch (Exception ex)
            {
                TempData["Exception"] = ex.Message;
            }
            return RedirectToAction("DersListesi");
        }

        public IActionResult DersListesi()
        {
            _entityListModel = new EntityListModel
            {
                kullanicilar = _uyedetayService.GetAll(),
                dersler = _dersService.GetAll(),
                sinavlar = _sinavService.GetAll()
            };
            if (TempData["Sonuc"] != null)
                ViewBag.Message = TempData["Sonuc"].ToString();
            if (TempData["Exception"] != null)
                ViewBag.Exceptions = TempData["Exception"].ToString();
            return View(_entityListModel);
        }

        public IActionResult DersEkle()
        {
            _entityListModel = new EntityListModel
            {
                sinavlar = _sinavService.GetListByStatus(1)
            };
            return View(_entityListModel);
        }

        [HttpPost]
        public async Task<IActionResult> DersEkle(string dersAd,int durum,int sinavId)
        {
            try
            {
                if (dersAd == null)
                    throw new RequiredFieldsException("Ders adı boş geçilemez!");

                var ders = _dersService.GetAll().Where(d => d.ders_ad.ToLower() == dersAd.ToLower()).FirstOrDefault();
                if (ders != null)
                    throw new Exception("Bu ders zaten kayıtlı");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Ders dersimiz = new Ders
                    {
                        sinav_id = sinavId,
                        ders_ad = dersAd,
                        eklenme_tarihi = DateTime.Now,
                        ekleyen_id = identityUser.uyeDetayId,
                        guncelleme_tarihi = DateTime.Now,
                        sil_id = durum,
                        guncelleyen_id = identityUser.uyeDetayId
                    };
                    _dersService.AddDers(dersimiz);
                    ViewBag.Message = "Ders başarıyla eklendi";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            _entityListModel = new EntityListModel
            {
                sinavlar = _sinavService.GetListByStatus(1)
            };
            return View(_entityListModel);
        }
    }
}