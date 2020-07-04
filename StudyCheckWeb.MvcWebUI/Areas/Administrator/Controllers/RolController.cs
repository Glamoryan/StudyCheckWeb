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
    public class RolController : Controller
    {
        UserManager<User> _userManager;
        IRolService _rolService;
        IUyedetayService _uyedetayService;
        IYetkiService _yetkiService;
        EntityListModel _entityListModel;        

        public RolController(IRolService rolService, IUyedetayService uyedetayService, IYetkiService yetkiService, UserManager<User> userManager)
        {
            _rolService = rolService;
            _uyedetayService = uyedetayService;
            _yetkiService = yetkiService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RolDuzenle(RolModel model)
        {
            model.tumYetkiler = _yetkiService.GetListByStatus(1);
            model.ekleyenKisi = _uyedetayService.GetById(model.ekleyenId).kullanici_adi;
            model.guncelleyenKisi = _uyedetayService.GetById(model.guncelleyenId).kullanici_adi;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RolDuzenle(int rolId,string rolAd,int durum,int rolYetki,string kayitTarihi,int ekleyenId)
        {
            try
            {
                if (rolAd == null)
                    throw new RequiredFieldsException("Rol adı boş geçilemez");
                var roller = _rolService.GetAll().Where(r => r.rol_adi == rolAd).ToList();
                if (roller.Count > 1)
                    throw new Exception("Bu rol adı zaten kayıtlı");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Rol updatedRol = new Rol
                    {
                        id = rolId,
                        ekleyen_id = ekleyenId,
                        guncelleyen_id = identityUser.uyeDetayId,
                        rol_adi = rolAd,
                        rol_guncelleme_tarihi = DateTime.Now,
                        rol_kayit_tarihi =Convert.ToDateTime(kayitTarihi),
                        sil_id = durum,
                        yetki_id = rolYetki
                    };
                    _rolService.UpdateRol(updatedRol);
                    TempData["Sonuc"] = "Rol başarıyla güncellendi";
                }
            }
            catch (Exception ex)
            {
                TempData["Exception"] = ex.Message;                
            }
            return RedirectToAction("RolListesi");
        }

        public IActionResult RolListesi()
        {
            _entityListModel = new EntityListModel
            {
                roller = _rolService.GetAll(),
                yetkiler = _yetkiService.GetAll(),
                kullanicilar = _uyedetayService.GetAll()
            };
            if (TempData["Sonuc"] != null)
                ViewBag.Message = TempData["Sonuc"].ToString();
            if(TempData["Exception"] != null)
                ViewBag.Exceptions = TempData["Exception"].ToString();
            return View(_entityListModel);
        }

        public IActionResult RolEkle()
        {
            _entityListModel = new EntityListModel
            {
                yetkiler = _yetkiService.GetListByStatus(1)
            };
            return View(_entityListModel);
        }

        [HttpPost]
        public async Task<IActionResult> RolEkle(string rolAd,int durum,int yetkiId)
        {
            try
            {
                if (rolAd == null)
                    throw new RequiredFieldsException("Rol adı boş geçilemez");

                var rol = _rolService.GetAll().Where(r => r.rol_adi.ToLower() == rolAd.ToLower()).FirstOrDefault();
                if (rol != null)
                    throw new Exception("Bu rol zaten kayıtlı");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Rol rolumuz = new Rol
                    {
                        rol_adi = rolAd,
                        rol_kayit_tarihi = DateTime.Now,
                        ekleyen_id = identityUser.uyeDetayId,
                        rol_guncelleme_tarihi = DateTime.Now,
                        sil_id = durum,
                        yetki_id = yetkiId,
                        guncelleyen_id = identityUser.uyeDetayId
                    };
                    _rolService.AddRol(rolumuz);
                    ViewBag.Message = "Rol başarıyla oluşturuldu";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            _entityListModel = new EntityListModel
            {
                yetkiler = _yetkiService.GetListByStatus(1)
            };
            return View(_entityListModel);
        }
    }
}