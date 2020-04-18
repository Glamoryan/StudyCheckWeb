using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface ITemaService
    {
        List<Tema> GetAll();
        List<Tema> GetListByStatus(int silId);
        Tema GetById(int id);
        void AddTema(Tema tema);
        void UpdateTema(Tema tema);
        void DeleteTema(Tema tema);
    }
}
