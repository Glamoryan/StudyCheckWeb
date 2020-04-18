using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class DersManager : IDersService
    {
        IDersDal _dersDal;
        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }
        public void AddDers(Ders ders)
        {
            _dersDal.Add(ders);
        }

        public void DeleteDers(Ders ders)
        {
            _dersDal.Delete(ders);
        }

        public List<Ders> GetAll()
        {
            return _dersDal.GetList();
        }

        public Ders GetById(int id)
        {
            return _dersDal.Get(d => d.id == id);
        }

        public List<Ders> GetListBySinavId(int sinavId)
        {
            return _dersDal.GetList(d => d.sinav_id == sinavId);
        }

        public List<Ders> GetListByStatus(int silId)
        {
            return _dersDal.GetList(d => d.sil_id == silId);
        }

        public void UpdateDers(Ders ders)
        {
            _dersDal.Update(ders);
        }
    }
}
