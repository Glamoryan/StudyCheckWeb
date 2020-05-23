using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize]
    public class IdentityYetkiController : Controller
    {
        private UserManager<User> _userManager;
        private IdentityListModel _identityListModel;

        public IdentityYetkiController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YetkiVer()
        {
            _identityListModel = new IdentityListModel
            {
                Users = _userManager.Users.ToList()
            };
            return View(_identityListModel);
        }

    }
}