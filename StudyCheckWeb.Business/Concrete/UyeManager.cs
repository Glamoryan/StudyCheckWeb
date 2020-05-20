using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Uye AddUser(Uye uye)
        {
            _uyeDal.Add(uye);
            return uye;
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

        public Uye UpdateUser(Uye uye)
        {
            _uyeDal.Update(uye);
            return uye;
        }

        public UserDetail GetUserDetailByUyeId(int uyeId)
        {
            return _uyeDal.GetUserDetails().Where(x => x.uye_id == uyeId).SingleOrDefault();
        }

        public List<UserDetail> GetAllUserDetail()
        {
            return _uyeDal.GetUserDetails();
        }
    }
}
