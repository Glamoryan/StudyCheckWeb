using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Models;
using StudyCheckWeb.MvcWebUI.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.ViewComponents
{
    public class NotificationViewComponent:ViewComponent
    {
        private IdentityListModel _identityListModel;
        private UserManager<User> _userManager;

        public NotificationViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public ViewViewComponentResult Invoke()
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
