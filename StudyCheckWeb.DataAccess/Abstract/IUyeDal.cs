﻿using StudyCheckWeb.Core.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Abstract
{
    public interface IUyeDal:IEntityRepository<Uye>
    {
        List<UserDetail> GetUserDetails();
    }
}
