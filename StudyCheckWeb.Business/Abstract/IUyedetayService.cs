﻿using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface IUyedetayService
    {
        List<Uyedetay> GetAll();
        List<Uyedetay> GetListByUserId(int uyeId);
        List<Uyedetay> GetListByStatus(int silId);
        List<Uyedetay> GetListByRoleId(int rolId);
        Uyedetay GetById(int id);
        void AddUyedetay(Uyedetay uyedetay);
        void UpdateUyedetay(Uyedetay uyedetay);
        void DeleteUyedetay(Uyedetay uyedetay);
    }
}
