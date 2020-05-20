using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface IUyeService
    {
        List<Uye> GetAll();        
        Uye GetById(int id);
        Uye AddUser(Uye uye);
        Uye UpdateUser(Uye uye);
        void DeleteUser(Uye uye);
        List<UserDetail> GetAllUserDetail();
        UserDetail GetUserDetailByUyeId(int id);
    }
}
