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

        [HttpPost]
        public async Task<JsonResult> updateYetki(string IdentityRolId, string userName)
        {
            try
            {
                var kullanici = await _userManager.FindByNameAsync(userName);
                if(kullanici != null)
                {
                    var rol = await _roleManager.FindByIdAsync(IdentityRolId);
                    var kullaniciRolleri = await _userManager.GetRolesAsync(kullanici);
                    foreach (var role in kullaniciRolleri)
                    {
                        await _userManager.RemoveFromRoleAsync(kullanici, role);
                    }
                    if(rol != null)
                    {                        
                        await _userManager.AddToRoleAsync(kullanici, rol.Name);
                    }
                    else
                    {
                        throw new Exception("Rol bulunamadı");
                    }
                }
                else
                {
                    throw new Exception("Kullanıcı bulunamadı");
                }
                return Json(new {success=true,value="Kullanıcı başarıyla güncellendi" });
            }
            catch (Exception ex)
            {
                return Json(new {success=false,value=ex.Message });
            }
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