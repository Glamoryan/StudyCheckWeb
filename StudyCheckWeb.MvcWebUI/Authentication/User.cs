using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Authentication
{
    public class User:IdentityUser
    {
        public int uyeDetayId { get; set; }
        public int uyeId { get; set; }
        public string uyeAdi { get; set; }
        public string uyeSoyadi { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSifre { get; set; }
        public string kullaniciMail { get; set; }
        public int rolId { get; set; }

    }
}
