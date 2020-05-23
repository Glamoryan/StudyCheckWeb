using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class SinavController : Controller
    {
        IUyedetayService _uyedetayService;
        ISinavService _sinavService;
        EntityListModel _entityListModel;

        public SinavController(IUyedetayService uyedetayService, ISinavService sinavService)
        {
            _uyedetayService = uyedetayService;
            _sinavService = sinavService;
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
        public IActionResult SinavEkle(string sinavAdi,int durum,string sinavTarihi)
        {
            try
            {
                if (sinavAdi == null)
                    throw new RequiredFieldsException("Sınav adı boş bırakılamaz");
                if(sinavTarihi == null)
                    throw new RequiredFieldsException("Sınav tarihi boş bırakılamaz");
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            return View();
        }
    }
}