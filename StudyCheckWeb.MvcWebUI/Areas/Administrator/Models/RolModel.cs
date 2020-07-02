using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class RolModel
    {
        public int rolId { get; set; }
        public string rolAd { get; set; }
        public DateTime kayitTarihi { get; set; }
        public int ekleyenId { get; set; }
        public DateTime guncellemeTarihi { get; set; }
        public int silId { get; set; }
        public int yetkiId { get; set; }
        public int guncelleyenId { get; set; }
        //-----------------------------------------
        public List<Yetki> tumYetkiler { get; set; }
    }
}
