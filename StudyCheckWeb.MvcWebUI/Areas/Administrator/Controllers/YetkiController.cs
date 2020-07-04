using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class YetkiController : Controller
    {
        IYetkiService _yetkiService;
        IUyedetayService _uyedetayService;
        EntityListModel _entityListModel;
        UserManager<User> _userManager;

        public YetkiController(IYetkiService yetkiService, IUyedetayService uyedetayService, UserManager<User> userManager)
        {
            _yetkiService = yetkiService;
            _uyedetayService = uyedetayService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YetkiDuzenle(YetkiModel model)
        {
            model.ekleyenKisi = _uyedetayService.GetById(model.ekleyenId).kullanici_adi;
            model.guncelleyenKisi = _uyedetayService.GetById(model.guncelleyenId).kullanici_adi;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> YetkiDuzenle(int yetkiId,string yetkiAd,int ekleyenId,string eklenmeTarihi,int durum)
        {
            try
            {
                if (yetkiAd == null)
                    throw new RequiredFieldsException("Yetki adı boş geçilemez!");

                var yetki = _yetkiService.GetAll().Where(y => y.yetki_adi == yetkiAd).ToList();
                if (yetki.Count > 1)
                    throw new Exception("Bu yetki adı zaten kayıtlı");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Yetki updatedYetki = new Yetki
                    {
                        id = yetkiId,
                        eklenme_tarihi = Convert.ToDateTime(eklenmeTarihi),
                        ekleyen_id = ekleyenId,
                        guncelleme_tarihi = DateTime.Now,
                        guncelleyen_id = identityUser.uyeDetayId,
                        sil_id = durum,
                        yetki_adi = yetkiAd
                    };
                    _yetkiService.UpdateYetki(updatedYetki);
                    TempData["Sonuc"] = "Yetki başarıyla güncellendi";
                }
            }
            catch (Exception ex)
            {
                TempData["Exception"] = ex.Message;
            }
            return RedirectToAction("YetkiListesi");
        }

        public IActionResult YetkiListesi()
        {
            _entityListModel = new EntityListModel
            {
                yetkiler = _yetkiService.GetAll(),
                kullanicilar = _uyedetayService.GetAll()
            };
            if (TempData["Sonuc"] != null)
                ViewBag.Message = TempData["Sonuc"].ToString();
            if (TempData["Exception"] != null)
                ViewBag.Exceptions = TempData["Exception"].ToString();
            return View(_entityListModel);
        }

        public IActionResult YetkiEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> YetkiEkle(string yetkiAd,int durum)
        {
            try
            {
                if (yetkiAd == null)
                    throw new RequiredFieldsException("Yetki adı boş bırakılamaz");

                var yetki = _yetkiService.GetAll().Where(y => y.yetki_adi.ToLower() == yetkiAd.ToLower()).FirstOrDefault();
                if (yetki != null)
                    throw new Exception("Bu yetki zaten mevcut");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Yetki yetkimiz = new Yetki
                    {
                        yetki_adi = yetkiAd,
                        ekleyen_id = identityUser.uyeDetayId,
                        eklenme_tarihi = DateTime.Now,
                        sil_id = durum,
                        guncelleyen_id = identityUser.uyeDetayId,
                        guncelleme_tarihi =DateTime.Now
                    };
                    _yetkiService.AddYetki(yetkimiz);
                    ViewBag.Message = "Yetki başarıyla oluşturuldu";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;                
            }
            return View();
        }
    }
}