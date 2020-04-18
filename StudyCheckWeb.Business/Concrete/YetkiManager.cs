using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class YetkiManager : IYetkiService
    {
        IYetkiDal _yetkiDal;
        public YetkiManager(IYetkiDal yetkiDal)
        {
            _yetkiDal = yetkiDal;
        }
        public void AddYetki(Yetki yetki)
        {
            _yetkiDal.Add(yetki);
        }

        public void DeleteYetki(Yetki yetki)
        {
            _yetkiDal.Delete(yetki);
        }

        public List<Yetki> GetAll()
        {
            return _yetkiDal.GetList();
        }

        public Yetki GetById(int id)
        {
            return _yetkiDal.Get(y => y.id == id);
        }

        public List<Yetki> GetListByStatus(int silId)
        {
            return _yetkiDal.GetList(y => y.sil_id == silId);
        }

        public void UpdateYetki(Yetki yetki)
        {
            _yetkiDal.Update(yetki);
        }
    }
}
