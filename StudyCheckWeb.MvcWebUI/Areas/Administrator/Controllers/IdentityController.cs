using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class IdentityController:Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private IdentityListModel _identityListModel;

        public IdentityController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoleListesi()
        {
            _identityListModel = new IdentityListModel
            {
                IdentityRoles = _roleManager.Roles.ToList()
            };
            return View(_identityListModel);
        }
        
        public IActionResult RoleEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleEkle(string roleName,string normalizedName)
        {
            try
            {
                if (roleName == null || normalizedName == null)
                    throw new Exception("Hiçbir alan boş bırakılamaz!");
                if(await _roleManager.FindByNameAsync(roleName) != null)
                    throw new Exception("Bu rol adı zaten kayıtlı!");
                else
                {
                    IdentityRole role = new IdentityRole
                    {
                        Name = roleName,
                        NormalizedName = normalizedName,
                        ConcurrencyStamp = roleName
                    };
                    var result = await _roleManager.CreateAsync(role);
                    if (result.Succeeded)
                    {
                        ViewBag.Success = "Rol başarıyla oluşturuldu";
                        return View();
                    }
                    else
                    {
                        ViewBag.IdentityResult = result;
                        throw new Exception("Hata");
                    }                        
                }

            }
            catch (Exception ex)
            {
                ViewBag.Exceptions = ex.Message;
            }
            return View();
        }

    }
}
