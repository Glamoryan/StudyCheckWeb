using StudyCheckWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Concrete
{
    public class Rol : IEntity
    {
        public int id { get; set; }
        public string rol_adi { get; set; }
        public DateTime rol_kayit_tarihi { get; set; }
        public int ekleyen_id { get; set; }
        public DateTime rol_guncelleme_tarihi { get; set; }
        public int sil_id { get; set; }
        public int yetki_id { get; set; }
        public int guncelleyen_id { get; set; }
    }
}
