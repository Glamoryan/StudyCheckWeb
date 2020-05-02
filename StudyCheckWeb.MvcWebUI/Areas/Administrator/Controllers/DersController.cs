using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class DersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DersListesi()
        {
            return View();
        }

        public IActionResult DersEkle()
        {
            return View();
        }
    }
}