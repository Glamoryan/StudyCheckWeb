
using StudyCheckWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Concrete
{
    public class Uye : IEntity
    {
        public int id { get; set; }
        public string uye_ad { get; set; }
        public string uye_soyad { get; set; }
    }
}
