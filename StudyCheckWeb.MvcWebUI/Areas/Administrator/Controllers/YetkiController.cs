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
    public class YetkiController : Controller
    {
        IYetkiService _yetkiService;
        IUyedetayService _uyedetayService;
        EntityListModel _entityListModel;

        public YetkiController(IYetkiService yetkiService, IUyedetayService uyedetayService)
        {
            _yetkiService = yetkiService;
            _uyedetayService = uyedetayService;            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YetkiListesi()
        {
            _entityListModel = new EntityListModel
            {
                yetkiler = _yetkiService.GetAll(),
                kullanicilar = _uyedetayService.GetAll()
            };
            return View(_entityListModel);
        }

        public IActionResult YetkiEkle()
        {
            return View();
        }
    }
}