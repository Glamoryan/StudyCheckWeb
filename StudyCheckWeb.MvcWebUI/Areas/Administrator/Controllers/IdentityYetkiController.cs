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
        private RoleManager<IdentityRole> _roleManager;        

        public IdentityYetkiController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
                Users = new List<User>(),
                IdentityRoles = _roleManager.Roles.ToList()
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
        
        [HttpPost]
        public async Task<IActionResult> YetkiVer(string RoleId, string UserId)//Identity
        {
            try
            {
                if (RoleId == null || UserId == null)
                    throw new Exception("Değerler Geçersiz!");
                else
                {
                    var role = _roleManager.FindByIdAsync(RoleId);
                    var user = _userManager.FindByIdAsync(UserId);
                    var roleResult = await _userManager.AddToRoleAsync(user.Result, role.Result.Name);
                    if (roleResult.Succeeded)
                    {
                        ViewBag.Success = "Kullanıcı Onaylandı";                        
                    }
                    else
                        throw new Exception(roleResult.Errors.ToString());
                }
            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            List<User> allUsers = _userManager.Users.ToList();
            _identityListModel = new IdentityListModel
            {
                Users = new List<User>(),
                IdentityRoles = _roleManager.Roles.ToList()
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