using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class RolManager : IRolService
    {
        IRolDal _rolDal;
        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }
        public void AddRol(Rol rol)
        {
            _rolDal.Add(rol);
        }

        public void DeleteRol(Rol rol)
        {
            _rolDal.Delete(rol);
        }

        public List<Rol> GetAll()
        {
            return _rolDal.GetList();
        }

        public Rol GetById(int id)
        {
            return _rolDal.Get(r => r.id == id);
        }

        public List<Rol> GetListByStatus(int silId)
        {
            return _rolDal.GetList(r => r.sil_id == silId);
        }

        public List<Rol> GetListByYetkiId(int yetkiId)
        {
            return _rolDal.GetList(r => r.yetki_id == yetkiId);
        }

        public void UpdateRol(Rol rol)
        {
            _rolDal.Update(rol);
        }
    }
}
