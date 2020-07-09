using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Study.Models
{
    public class PanelModel
    {
        public UserDetail userDetail { get; set; }
        public List<Calisma> tumCalismalar { get; set; }
        //----------------------------
        public string rolAdi { get; set; }
        public string toplamCalisilanZaman { get; set; }
        public string sonCalisilanDers { get; set; }
        public string sonCalisilanSinav { get; set; }
        public string sonCalismaTarihi { get; set; }
        public string sinavaCalisilanToplamZaman { get; set; }
        public string derseCalisilanToplamZaman { get; set; }
        public string sinavTarihi { get; set; }
        public string derseSonCalisilanZaman { get; set; }
    }
}
