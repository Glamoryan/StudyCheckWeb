using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class SinavManager : ISinavService
    {
        ISinavDal _sinavDal;
        public SinavManager(ISinavDal sinavDal)
        {
            _sinavDal = sinavDal;        
        }
        public void AddSinav(Sinav sinav)
        {
            _sinavDal.Add(sinav);
        }

        public void DeleteSinav(Sinav sinav)
        {
            _sinavDal.Delete(sinav);
        }

        public List<Sinav> GetAll()
        {
            return _sinavDal.GetList();
        }

        public Sinav GetById(int id)
        {
            return _sinavDal.Get(s => s.id == id);
        }

        public List<Sinav> GetListByStatus(int silId)
        {
            return _sinavDal.GetList(s => s.sil_id == silId);
        }

        public void UpdateSinav(Sinav sinav)
        {
            _sinavDal.Update(sinav);
        }
    }
}
