using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class YetkiModel
    {
        public int yetkiId { get; set; }
        public string yetkiAd { get; set; }
        public int ekleyenId { get; set; }
        public DateTime eklenmeTarihi { get; set; }
        public int silId { get; set; }
        public int guncelleyenId { get; set; }
        public DateTime guncellemeTarihi { get; set; }
        //------------------------------------------------
        public string ekleyenKisi { get; set; }
        public string guncelleyenKisi { get; set; }
    }
}
