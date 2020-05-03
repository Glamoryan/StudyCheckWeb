using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class KullaniciController : Controller
    {
        IUyeService _uyeService;
        EntityListModel _entityListModel;

        public KullaniciController(IUyeService uyeService)
        {
            _uyeService = uyeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KullaniciListesi()
        {
            _entityListModel = new EntityListModel
            {
                UserDetails = _uyeService.GetAllUserDetail()
            };
            return View(_entityListModel);
        }
        public IActionResult KullaniciEkle()
        {
            return View();
        }
    }
}