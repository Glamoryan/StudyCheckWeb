using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface IDersService
    {
        List<Ders> GetAll();
        List<Ders> GetListByStatus(int silId);
        List<Ders> GetListBySinavId(int sinavId);
        Ders GetById(int id);
        void AddDers(Ders ders);
        void DeleteDers(Ders ders);
        void UpdateDers(Ders ders);
    }
}
