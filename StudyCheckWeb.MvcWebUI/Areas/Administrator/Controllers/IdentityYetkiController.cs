using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
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
            List<User> allUsers = _userManager.Users.ToList();
            _identityListModel = new IdentityListModel
            {
                Users = new List<User>()
            };
            IList<string> result;
            foreach (User user in allUsers)
            {
                result = _userManager.GetRolesAsync(user).Result;
                if (result.Count == 0)
                {
                    _identityListModel.Users.Add(user);
                }
            }            
            return View(_identityListModel);
        }

    }
}