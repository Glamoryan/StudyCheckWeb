using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class SinavController : Controller
    {
        IUyedetayService _uyedetayService;
        ISinavService _sinavService;
        EntityListModel _entityListModel;
        UserManager<User> _userManager;

        public SinavController(IUyedetayService uyedetayService, ISinavService sinavService, UserManager<User> userManager)
        {
            _uyedetayService = uyedetayService;
            _sinavService = sinavService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SinavListesi()
        {
            _entityListModel = new EntityListModel
            {
                sinavlar = _sinavService.GetAll(),
                kullanicilar = _uyedetayService.GetAll()
            };
            return View(_entityListModel);
        }

        public IActionResult SinavEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SinavEkle(string sinavAdi,int durum,string sinavTarihi)
        {
            try
            {
                if (sinavAdi == null)
                    throw new RequiredFieldsException("Sınav adı boş bırakılamaz");
                if(sinavTarihi == null)
                    throw new RequiredFieldsException("Sınav tarihi boş bırakılamaz");

                var sinav = _sinavService.GetAll().Where(s => s.sinav_ad.ToLower() == sinavAdi.ToLower()).FirstOrDefault();
                if (sinav != null)
                    throw new Exception("Bu sınav zaten kayıtlı");
                else
                {
                    var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                    Sinav sinavimiz = new Sinav
                    {
                        sinav_ad = sinavAdi,
                        sinav_tarih = Convert.ToDateTime(sinavTarihi),
                        eklenme_tarihi = DateTime.Now,
                        ekleyen_id = identityUser.uyeDetayId,
                        guncelleme_tarihi = DateTime.Now,
                        sil_id = durum,
                        guncelleyen_id = identityUser.uyeDetayId
                    };
                    _sinavService.AddSinav(sinavimiz);
                    ViewBag.Message = "Sınav başarıyla eklendi";
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