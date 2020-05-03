using StudyCheckWeb.Core.DataAccess.Concrete.EntityFramework;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.DataAccess.Concrete.EntityFramework.Contexts;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework
{
    public class EfUyeDal:EfEntityRepositoryBase<Uye,StudyCheckContext>,IUyeDal
    {
        public List<UserDetail> GetUserDetails()
        {
            using (StudyCheckContext context = new StudyCheckContext())
            {
                var sonuc = from u in context.Uyeler
                            join ud in context.UyeDetay on u.id equals ud.uye_id
                            select new UserDetail
                            {
                                uyedetay_id = ud.id,
                                uye_id = u.id,
                                uye_ad = u.uye_ad,
                                uye_soyad = u.uye_soyad,
                                kullanici_adi = ud.kullanici_adi,
                                kullanici_sifre = ud.kullanici_sifre,
                                kullanici_mail = ud.kullanici_mail,
                                kayit_tarihi = ud.kayit_tarihi,
                                guncelleme_tarihi = ud.guncelleme_tarihi,
                                sil_id = ud.sil_id,
                                tema_id = ud.tema_id,
                                rol_id = ud.rol_id,
                                guncelleyen_id = ud.guncelleyen_id
                            };
                return sonuc.ToList();
            }
        }
    }
}
