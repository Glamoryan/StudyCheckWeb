﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Concrete
{
    public class Uyedetay
    {
        public int id { get; set; }
        public int uye_id { get; set; }
        public string kullanici_adi { get; set; }
        public string kullanici_sifre { get; set; }
        public string kullanici_mail { get; set; }
        public DateTime kayit_tarihi { get; set; }
        public DateTime guncelleme_tarihi { get; set; }
        public int sil_id { get; set; }
        public int tema_id { get; set; }
        public int rol_id { get; set; }
        public int guncelleyen_id { get; set; }
    }
}
