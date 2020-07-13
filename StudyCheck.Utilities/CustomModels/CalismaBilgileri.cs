using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheck.Utilities.CustomModels
{
    public class CalismaBilgileri
    {
        public int data { get; set; } //1-veri var , 0-veri yok
        public string toplamCalisilanZaman { get; set; }
        public string sonCalisilanSinav { get; set; }
        public string sonCalisilanDers { get; set; }
        public string sonCalismaTarihi { get; set; }
        public string sinavaCalisilanZaman { get; set; }
        public string derseCalisilanZaman { get; set; }
        public string sinavTarihi { get; set; }
        public string derseSonCalisilanZaman { get; set; }
        public string sinavaKalanGun { get; set; }
    }
}
