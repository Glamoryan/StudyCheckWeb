using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface IYetkiService
    {
        List<Yetki> GetAll();
        List<Yetki> GetListByStatus(int silId);
        Yetki GetById(int id);
        void AddYetki(Yetki yetki);
        void UpdateYetki(Yetki yetki);
        void DeleteYetki(Yetki yetki);
    }
}
