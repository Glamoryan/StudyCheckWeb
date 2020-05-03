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
    public class DashboardController : Controller
    {
        IUyedetayService _uyedetayService;
        ISinavService _sinavService;
        ITemaService _temaService;
        IDersService _dersService;
        IRolService _rolService;
        IYetkiService _yetkiService;
        DashboardModel _dashboardModel;    

        public DashboardController(IUyedetayService uyedetayService, ISinavService sinavService, ITemaService temaService, IDersService dersService, IRolService rolService, IYetkiService yetkiService)
        {
            _uyedetayService = uyedetayService;
            _sinavService = sinavService;
            _temaService = temaService;
            _dersService = dersService;
            _rolService = rolService;
            _yetkiService = yetkiService;
        }

        public IActionResult Index()
        {
            _dashboardModel = new DashboardModel 
            {
                kullanicilar = _uyedetayService.GetAll(),
                dersler = _dersService.GetAll(),
                roller = _rolService.GetAll(),
                sinavlar = _sinavService.GetAll(),
                temalar = _temaService.GetAll(),
                yetkiler = _yetkiService.GetAll()
            };
            return View(_dashboardModel);
        } 
    }
}