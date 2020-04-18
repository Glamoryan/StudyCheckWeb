using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class CalismaManager : ICalismaService
    {
        ICalismaDal _calismaDal;
        public CalismaManager(ICalismaDal calismaDal)
        {
            _calismaDal = calismaDal;
        }
        public void AddCalisma(Calisma calisma)
        {
            _calismaDal.Add(calisma);
        }

        public void DeleteCalisma(Calisma calisma)
        {
            _calismaDal.Delete(calisma);
        }

        public List<Calisma> GetAll()
        {
            return _calismaDal.GetList();
        }

        public Calisma GetById(int id)
        {
            return _calismaDal.Get(c => c.id == id);
        }

        public List<Calisma> GetListByUyeId(int uyeId, int? sinavId = null, int? dersId = null)
        {
            return (sinavId == null && dersId == null) ? _calismaDal.GetList(c => c.uye_id == uyeId)
                : (sinavId != null && dersId==null) ? _calismaDal.GetList(c => c.uye_id == uyeId && c.sinav_id == sinavId)
                : _calismaDal.GetList(c => c.uye_id == uyeId &&c.sinav_id==sinavId && c.ders_id == dersId);
        }

        public void UpdateCalisma(Calisma calisma)
        {
            _calismaDal.Update(calisma);
        }
    }
}
