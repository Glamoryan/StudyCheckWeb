using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface IRolService
    {
        List<Rol> GetAll();
        List<Rol> GetListByStatus(int silId);
        List<Rol> GetListByYetkiId(int yetkiId);
        Rol GetById(int id);
        void AddRol(Rol rol);
        void UpdateRol(Rol rol);
        void DeleteRol(Rol rol);
    }
}
