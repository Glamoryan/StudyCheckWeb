using Microsoft.AspNetCore.Identity;
using StudyCheckWeb.MvcWebUI.Areas.Administrator.Utilities;
using StudyCheckWeb.MvcWebUI.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class IdentityListModel
    {
        public List<IdentityRole> IdentityRoles { get; set; }
        public List<User> Users { get; set; }
        public List<UserAndRoles> UsersAndRoles { get; set; }
    }
}
