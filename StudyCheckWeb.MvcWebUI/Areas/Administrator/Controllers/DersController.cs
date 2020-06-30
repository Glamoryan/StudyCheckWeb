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

        public IActionResult DersListesi()
        {
            _entityListModel = new EntityListModel
            {
                kullanicilar = _uyedetayService.GetAll(),
                dersler = _dersService.GetAll(),
                sinavlar = _sinavService.GetAll()
            };
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