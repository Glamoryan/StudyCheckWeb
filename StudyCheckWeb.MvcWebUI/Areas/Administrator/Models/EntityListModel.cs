using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCheckWeb.MvcWebUI.Areas.Administrator.Models
{
    public class EntityListModel
    {
        public List<Uyedetay> kullanicilar { get; set; }
        public List<Sinav> sinavlar { get; set; }
        public List<Tema> temalar { get; set; }
        public List<Ders> dersler { get; set; }
        public List<Rol> roller { get; set; }
        public List<Yetki> yetkiler { get; set; }

        //Complex Type
        public List<UserDetail> UserDetails { get; set; }

        //loginli kullanıcı bilgileri
        public int AdminID { get; set; }        
    }
}
