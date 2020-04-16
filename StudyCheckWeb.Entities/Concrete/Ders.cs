using StudyCheck.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Concrete
{
    public class Ders:IEntity
    {
        public int id { get; set; }
        public int sinav_id { get; set; }
        public string ders_ad { get; set; }
        public DateTime eklenme_tarihi { get; set; }
        public int ekleyen_id { get; set; }
        public DateTime guncelleme_tarihi { get; set; }
        public int sil_id { get; set; }
        public int guncelleyen_id { get; set; }
    }
}
