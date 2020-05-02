using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class YetkiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YetkiListesi()
        {
            return View();
        }

        public IActionResult YetkiEkle()
        {
            return View();
        }
    }
}