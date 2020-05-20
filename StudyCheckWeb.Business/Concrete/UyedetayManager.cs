using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class UyedetayManager : IUyedetayService
    {
        IUyeDetayDal _uyeDetayDal;
        public UyedetayManager(IUyeDetayDal uyeDetayDal)
        {
            _uyeDetayDal = uyeDetayDal;
        }
        public Uyedetay AddUyedetay(Uyedetay uyedetay)
        {
            _uyeDetayDal.Add(uyedetay);
            return uyedetay;
        }

        public void DeleteUyedetay(Uyedetay uyedetay)
        {
            _uyeDetayDal.Delete(uyedetay);
        }

        public List<Uyedetay> GetAll()
        {
            return _uyeDetayDal.GetList();
        }

        public Uyedetay GetById(int id)
        {
            return _uyeDetayDal.Get(u => u.id == id);
        }

        public List<Uyedetay> GetListByRoleId(int rolId)
        {
            return _uyeDetayDal.GetList(u=>u.rol_id==rolId);
        }

        public List<Uyedetay> GetListByStatus(int silId)
        {
            return _uyeDetayDal.GetList(u => u.sil_id == silId);
        }

        public List<Uyedetay> GetListByUserId(int uyeId)
        {
            return _uyeDetayDal.GetList(u => u.uye_id == uyeId);
        }

        public Uyedetay UpdateUyedetay(Uyedetay uyedetay)
        {
            _uyeDetayDal.Update(uyedetay);
            return uyedetay;
        }
    }
}
