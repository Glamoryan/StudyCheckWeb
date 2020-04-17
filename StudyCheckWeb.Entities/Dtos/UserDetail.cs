
using StudyCheckWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Dtos
{
    /// <summary>
    /// Uye ve Uyedetay tablosunun birleşimi
    /// </summary>
    public class UserDetail : IDto
    {
        public int uye_id { get; set; }
        public int uyedetay_id { get; set; }
        public string uye_ad { get; set; }
        public string uye_soyad { get; set; }
        public string kullanici_adi { get; set; }
        public string kullanici_sifre { get; set; }
        public string kullanici_mail { get; set; }
        public DateTime kayit_tarihi { get; set; }
        public DateTime guncelleme_tarihi{ get; set; }
        public int sil_id { get; set; }
        public int tema_id { get; set; }
        public int rol_id { get; set; }
        public int guncelleyen_id { get; set; }
    }
}
