
using StudyCheckWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Concrete
{
    public class Tema : IEntity
    {
        public int id { get; set; }
        public string tema_adi { get; set; }
        public DateTime eklenme_tarihi { get; set; }
        public int ekleyen_id { get; set; }
        public int sil_id { get; set; }
    }
}
