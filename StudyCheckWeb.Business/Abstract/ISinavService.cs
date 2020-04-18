using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface ISinavService
    {
        List<Sinav> GetAll();
        List<Sinav> GetListByStatus(int silId);
        Sinav GetById(int id);
        void AddSinav(Sinav sinav);
        void DeleteSinav(Sinav sinav);
        void UpdateSinav(Sinav sinav);
    }
}
