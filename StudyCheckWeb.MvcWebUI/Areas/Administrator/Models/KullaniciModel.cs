using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class KullaniciModel
    {
        public int uyeId { get; set; }
        public int uyeDetayId { get; set; }
        public string uyeAd { get; set; }
        public string uyeSoyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSifre { get; set; }
        public string kullaniciMail { get; set; }
        public DateTime kayitTarihi { get; set; }
        public DateTime guncellemeTarihi { get; set; }
        public int silId { get; set; }
        public int temaId { get; set; }
        public int rolId { get; set; }
        public int guncelleyenId { get; set; }
        //-------------------------------------------
        public List<Rol> tumRoller { get; set; }
        public string guncelleyenKisi { get; set; }
    }
}
