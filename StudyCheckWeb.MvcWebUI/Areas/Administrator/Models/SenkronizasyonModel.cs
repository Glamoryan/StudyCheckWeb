using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class SenkronizasyonModel
    {
        public int senkron { get; set; } // 0-Senkron değil , 1-Senkron
        public string senkronUsername { get; set; }
    }
}
