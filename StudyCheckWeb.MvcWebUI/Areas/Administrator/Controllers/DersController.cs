using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class DersController : Controller
    {
        IDersService _dersService;
        ISinavService _sinavService;
        IUyedetayService _uyedetayService;
        EntityListModel _entityListModel;

        public DersController(IDersService dersService, ISinavService sinavService, IUyedetayService uyedetayService)
        {
            _dersService = dersService;
            _sinavService = sinavService;
            _uyedetayService = uyedetayService;
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
            return View();
        }
    }
}