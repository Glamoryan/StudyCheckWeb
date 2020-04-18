using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class UyeManager : IUyeService
    {
        IUyeDal _uyeDal;
        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }
        public void AddUser(Uye uye)
        {
            _uyeDal.Add(uye);
        }

        public void DeleteUser(Uye uye)
        {
            _uyeDal.Delete(uye);
        }

        public List<Uye> GetAll()
        {
            return _uyeDal.GetList();
        }

        public Uye GetById(int id)
        {
            return _uyeDal.Get(u=>u.id==id);
        }

        public void UpdateUser(Uye uye)
        {
            _uyeDal.Update(uye);
        }
    }
}
