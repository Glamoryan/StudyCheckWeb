using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyCheckWeb.Business.Concrete;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Utilities;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class IdentityRoleController : Controller
    {
        UserManager<User> _userManager;        
        IdentityListModel _listModel;
        UserAndRoles _kayitliKullanici;
        RoleManager<IdentityRole> _roleManager;

        public IdentityRoleController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }        

        public async Task<IActionResult> YetkiliListesi()
        {
            List<User> users = await _userManager.Users.ToListAsync();            
            _listModel = new IdentityListModel
            {
                UsersAndRoles = new List<UserAndRoles>()
            };
            foreach (var user in users)
            {
                string rolInfo = _userManager.GetRolesAsync(user).Result.SingleOrDefault();
                if(rolInfo != null)
                {
                    _kayitliKullanici = new UserAndRoles
                    {
                        roleName = rolInfo,
                        userName = user.UserName
                    };
                    _listModel.UsersAndRoles.Add(_kayitliKullanici);
                }                
            }
            _listModel.IdentityRoles = _roleManager.Roles.ToList();
            return View(_listModel);
        }
    }
}