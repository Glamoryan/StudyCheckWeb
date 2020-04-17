using StudyCheck.Core.DataAccess.EntityFramework;
using StudyCheckWeb.DataAccess.Abstract;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework
{
    public class EfUyeDal:EfEntityRepositoryBase<Uye,StudyCheckContext>,IUyeDal
    {

    }
}
