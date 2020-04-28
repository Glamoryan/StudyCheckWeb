using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult KullaniciListesi()
        {
            return View();
        }

        public IActionResult KullaniciEkle()
        {
            return View();
        }
    }
}