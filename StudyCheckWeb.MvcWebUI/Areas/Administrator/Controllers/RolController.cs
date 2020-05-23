using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class RolController : Controller
    {
        IRolService _rolService;
        IUyedetayService _uyedetayService;
        IYetkiService _yetkiService;
        EntityListModel _entityListModel;

        public RolController(IRolService rolService, IUyedetayService uyedetayService, IYetkiService yetkiService)
        {
            _rolService = rolService;
            _uyedetayService = uyedetayService;
            _yetkiService = yetkiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RolListesi()
        {
            _entityListModel = new EntityListModel
            {
                roller = _rolService.GetAll(),
                yetkiler = _yetkiService.GetAll(),
                kullanicilar = _uyedetayService.GetAll()
            };
            return View(_entityListModel);
        }

        public IActionResult RolEkle()
        {
            return View();
        }
    }
}