using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Concrete
{
    public class TemaManager : ITemaService
    {
        ITemaDal _temaDal;
        public TemaManager(ITemaDal temaDal)
        {
            _temaDal = temaDal;
        }
        public void AddTema(Tema tema)
        {
            _temaDal.Add(tema);
        }

        public void DeleteTema(Tema tema)
        {
            _temaDal.Delete(tema);
        }

        public List<Tema> GetAll()
        {
            return _temaDal.GetList();
        }

        public Tema GetById(int id)
        {
            return _temaDal.Get(t => t.id == id);
        }

        public List<Tema> GetListByStatus(int silId)
        {
            return _temaDal.GetList(t => t.sil_id == silId);
        }

        public void UpdateTema(Tema tema)
        {
            _temaDal.Update(tema);
        }
    }
}
