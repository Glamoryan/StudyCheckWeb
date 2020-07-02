using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class SinavModel
    {
        public int sinavId { get; set; }
        public string sinavAd { get; set; }
        public DateTime sinavTarihi { get; set; }
        public DateTime eklenmeTarihi { get; set; }
        public int ekleyenId { get; set; }
        public DateTime guncellemeTarihi { get; set; }
        public int silId { get; set; }
        public int guncelleyenId { get; set; }
        //------------------------------------------
        public string ekleyenKisi { get; set; }
        public string guncelleyenKisi { get; set; }
    }
}
