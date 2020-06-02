using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyCheck.Utilities.CustomExceptions;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class KullaniciController : Controller
    {
        IUyeService _uyeService;
        IRolService _rolService;
        EntityListModel _entityListModel;

        public KullaniciController(IUyeService uyeService, IRolService rolService)
        {
            _uyeService = uyeService;
            _rolService = rolService;
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
        public IActionResult KullaniciEkle(string kullaniciAdi,string sifre,string mail,int durum,int rol,string uyeAd,string uyeSoyad)
        {
            try
            {
                if (kullaniciAdi == null || sifre == null || mail == null)
                    throw new RequiredFieldsException("Kullanıcı bilgileri boş bırakılamaz!");
                else if (uyeAd == null || uyeSoyad == null)
                    throw new RequiredFieldsException("Üye bilgileri boş bırakılamaz!");       
                
                //Buraya Ekleme işlemi yapılacak
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