﻿using StudyCheck.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Entities.Concrete
{
    public class Calisma:IEntity
    {
        public int id { get; set; }
        public int uye_id { get; set; }
        public int sinav_id { get; set; }
        public int ders_id { get; set; }
        public TimeSpan calisilan_zaman { get; set; }
        public DateTime calisilan_tarih { get; set; }
    }
}
