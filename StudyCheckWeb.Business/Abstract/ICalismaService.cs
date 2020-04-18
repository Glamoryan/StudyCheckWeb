using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCheckWeb.Business.Abstract
{
    public interface ICalismaService
    {
        List<Calisma> GetAll();
        /// <summary>
        /// sinavId verilmezse kullanıcının tüm çalışmaları , sinavId verilirse kullanıcının o sınavla ilgili çalışmaları , dersId verilirse kullanıcının o derse ait tüm çalışmaları
        /// 
        /// </summary>
        /// <param name="uyeDetayId"></param>
        /// <param name="sinavId"></param>
        /// <param name="dersId"></param>
        /// <returns></returns>
        List<Calisma> GetListByUyeId(int uyeId, int? sinavId = null, int? dersId = null);
        Calisma GetById(int id);
        void AddCalisma(Calisma calisma);
#warning Calismalara mudahale edilmesi tavsiye edilmez
        void UpdateCalisma(Calisma calisma);
#warning Calismalara mudahale edilmesi tavsiye edilmez
        void DeleteCalisma(Calisma calisma);
    }
}
