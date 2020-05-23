using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Entities.Dtos;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="Admin")]
    public class DashboardController : Controller
    {
        IUyedetayService _uyedetayService;
        ISinavService _sinavService;
        ITemaService _temaService;
        IDersService _dersService;
        IRolService _rolService;
        IYetkiService _yetkiService;        

        EntityListModel _entityListModel;

        public DashboardController(IUyedetayService uyedetayService, ISinavService sinavService, ITemaService temaService, IDersService dersService, IRolService rolService, IYetkiService yetkiService)
        {
            _uyedetayService = uyedetayService;
            _sinavService = sinavService;
            _temaService = temaService;
            _dersService = dersService;
            _rolService = rolService;
            _yetkiService = yetkiService;            
        }

        public IActionResult Index(int kullaniciId)
        {
            _entityListModel = new EntityListModel
            {
                kullanicilar = _uyedetayService.GetAll(),
                dersler = _dersService.GetAll(),
                roller = _rolService.GetAll(),
                sinavlar = _sinavService.GetAll(),
                temalar = _temaService.GetAll(),
                yetkiler = _yetkiService.GetAll(),
                AdminID = kullaniciId
            };            
            return View(_entityListModel);
        }         
    }
}