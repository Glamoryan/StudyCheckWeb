using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class DersModel
    {
        public int dersId { get; set; }
        public int sinavId { get; set; }
        public string dersAd { get; set; }
        public DateTime eklenmeTarihi { get; set; }
        public int ekleyenId { get; set; }
        public DateTime guncellemeTarihi { get; set; }
        public int silId { get; set; }
        public int guncelleyenId { get; set; }
        //------------------------------------------
        public List<Sinav> tumSinavlar { get; set; }
        public string guncelleyenKisi { get; set; }
        public string ekleyenKisi { get; set; }

    }
}
