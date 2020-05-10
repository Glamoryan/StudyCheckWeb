using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize]
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
            return View();
        }
    }
}