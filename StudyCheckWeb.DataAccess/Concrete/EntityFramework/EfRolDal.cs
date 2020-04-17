﻿using StudyCheckWeb.Core.DataAccess.Concrete.EntityFramework;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.DataAccess.Concrete.EntityFramework.Contexts;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework
{
    public class EfRolDal:EfEntityRepositoryBase<Rol,StudyCheckContext>,IRolDal
    {
    }
}
