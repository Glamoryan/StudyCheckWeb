using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyCheck.Utilities.CustomModels;
using StudyCheckWeb.Business.Abstract;
using StudyCheckWeb.Entities.Concrete;
using StudyCheckWeb.MvcWebUI.Areas.Study.Models;
using StudyCheckWeb.MvcWebUI.Authentication;

namespace StudyCheckWeb.MvcWebUI.Areas.Study.Controllers
{
    [Area("Study")]
    [Authorize(Roles ="User")]
    public class HomeController : Controller
    {
        ICalismaService _calismaService;
        IUyedetayService _uyedetayService;
        IUyeService _uyeService;
        IRolService _rolService;
        ISinavService _sinavService;
        IDersService _dersService;
        UserManager<User> _userManager;
        PanelModel _model;

        public HomeController(ICalismaService calismaService, UserManager<User> userManager, IUyedetayService uyedetayService, IUyeService uyeService, IRolService rolService, ISinavService sinavService, IDersService dersService)
        {
            _calismaService = calismaService;
            _userManager = userManager;
            _uyedetayService = uyedetayService;
            _uyeService = uyeService;
            _rolService = rolService;
            _sinavService = sinavService;
            _dersService = dersService;
        }

        public CalismaBilgileri studyInfos(List<Calisma> calismalar,byte? durum=null,int? sinav_id=null,int? ders_id=null)
        {
            CalismaBilgileri bilgiler = new CalismaBilgileri();

            if(durum == null)
            {
                if (calismalar.Count > 0)
                {
                    //Toplam Çalışılan Zaman
                    TimeSpan toplamZaman = TimeSpan.Zero;
                    foreach (var calisma in calismalar)
                    {
                        toplamZaman += calisma.calisilan_zaman;
                    }
                    bilgiler.toplamCalisilanZaman = toplamZaman.ToString();

                    //Son Sınav
                    int? sonSinavId = calismalar.LastOrDefault().sinav_id;
                    if (sonSinavId == null)
                        bilgiler.sonCalisilanSinav = "-";
                    else
                    {
                        var sinav = _sinavService.GetById((int)sonSinavId);
                        bilgiler.sonCalisilanSinav = sinav.sinav_ad;
                        bilgiler.sinavTarihi = sinav.sinav_tarih.ToShortDateString();
                        bilgiler.derseSonCalisilanZaman = calismalar.LastOrDefault().calisilan_zaman.ToString();

                        //Sınava Çalışılan Toplam Zaman
                        TimeSpan sinavToplam = TimeSpan.Zero;
                        foreach (var calisma in calismalar)
                        {
                            if (calisma.sinav_id == sinav.id)
                                sinavToplam += calisma.calisilan_zaman;
                        }
                        bilgiler.sinavaCalisilanZaman = sinavToplam.ToString();
                    }

                    //Son Ders
                    int? sonDersId = calismalar.LastOrDefault().ders_id;
                    if (sonDersId == null)
                        bilgiler.sonCalisilanDers = "-";
                    else
                    {
                        var ders = _dersService.GetById((int)sonDersId);
                        bilgiler.sonCalisilanDers = ders.ders_ad;
                        bilgiler.sonCalismaTarihi = calismalar.LastOrDefault().calisilan_tarih.ToString();

                        //Derse Çalışılan Toplam Zaman
                        TimeSpan dersToplam = TimeSpan.Zero;
                        foreach (var calisma in calismalar)
                        {
                            if (calisma.ders_id == sonDersId)
                                dersToplam += calisma.calisilan_zaman;
                        }
                        bilgiler.derseCalisilanZaman = dersToplam.ToString();
                    }
                }
                else
                {
                    bilgiler.sinavaCalisilanZaman = "-";
                    bilgiler.derseCalisilanZaman = "-";
                    bilgiler.sonCalisilanDers = "-";
                    bilgiler.sonCalisilanSinav = "-";
                    bilgiler.sonCalismaTarihi = "-";
                    bilgiler.toplamCalisilanZaman = "-";
                    bilgiler.sinavTarihi = "-";
                    bilgiler.derseSonCalisilanZaman = "-";
                }
                return bilgiler;
            }
            else if (durum == 1) //Çalışma Bilgileri
            {
                if (calismalar.Count > 0)
                {                    
                    TimeSpan toplam = TimeSpan.Zero;
                    foreach (var calisma in calismalar)
                    {
                        if (calisma.sinav_id == sinav_id)
                            toplam += calisma.calisilan_zaman;
                    }
                    bilgiler.sinavaCalisilanZaman = toplam.ToString();

                    var sinav = _sinavService.GetById((int)sinav_id);
                    int kalan = Convert.ToInt32((sinav.sinav_tarih - DateTime.Now).TotalDays);
                    if (kalan < 0)
                        bilgiler.sinavaKalanGun = "Sınav süresi geçti";
                    else
                        bilgiler.sinavaKalanGun = kalan.ToString();

                    bilgiler.data = 1;
                }
                else
                {
                    bilgiler.data = 0;
                    bilgiler.sinavaCalisilanZaman = "-";
                    bilgiler.sinavaKalanGun = "-";                    
                }
                return bilgiler;   
            }
            else //Ders Bilgileri
            {
                if(calismalar.Count > 0)
                {
                    TimeSpan toplam = TimeSpan.Zero;
                    foreach (var calisma in calismalar)
                    {
                        if (calisma.ders_id == ders_id)
                            toplam += calisma.calisilan_zaman;
                    }
                    bilgiler.derseCalisilanZaman = toplam.ToString();

                    bilgiler.data = 1;
                }
                else
                {
                    bilgiler.data = 0;
                    bilgiler.derseCalisilanZaman = "-";
                }
                return bilgiler;
            }
        }        
        
        [HttpGet]
        public JsonResult GetDers(int sinavId) //Ders List için dersler
        {
            if (sinavId > 0)
            {
                List<Ders> dersler = _dersService.GetListBySinavId(sinavId);
                if (dersler.Count > 0)
                    return Json(new { success = true, value = dersler });
                else
                    return Json(new { success = true, value = "Veri Yok" });
            }
            else
                return Json(new {success=false,value = "Başarısız" });            
        }

        [HttpGet]
        public async Task<JsonResult> GetSinavBilgileri(int sinavId)
        {
            if (sinavId > 0)
            {
                var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                List<Calisma> calismalar = _calismaService.GetListByUyeId(identityUser.uyeDetayId);
                CalismaBilgileri bilgiler = studyInfos(calismalar, 1, sinavId);
                string sinavAd = _sinavService.GetById(sinavId).sinav_ad;
                if(bilgiler.data == 1)
                    return Json(new { success = true, topTime = bilgiler.sinavaCalisilanZaman, kalanGun = bilgiler.sinavaKalanGun,sinavAdi = sinavAd });
                else
                    return Json(new { success = true, topTime = "-", kalanGun = "-" , sinavAdi = "-"});
            }
            else
                return Json(new { success = false, value = "Başarısız" });
        }

        [HttpGet]
        public async Task<JsonResult> GetDersBilgileri(int dersId)
        {
            if(dersId > 0)
            {
                var identityUser = await _userManager.GetUserAsync(HttpContext.User);
                List<Calisma> calismalar = _calismaService.GetListByUyeId(identityUser.uyeDetayId);
                CalismaBilgileri bilgiler = studyInfos(calismalar, 2,null,dersId);
                string dersAd = _dersService.GetById(dersId).ders_ad;
                if (bilgiler.data == 1)
                    return Json(new { success = true, dtopTime = bilgiler.derseCalisilanZaman, dersAdi = dersAd });
                else
                    return Json(new { success = true, dtopTime = "-", dersAdi = "-" });
            }
            else
            {
                return Json(new { success = false, value = "Başarısız" });
            }
        }

        public async Task<IActionResult> Index()
        {
            var identityUser = await _userManager.GetUserAsync(HttpContext.User);
            Uyedetay kullanici = _uyedetayService.GetById(identityUser.uyeDetayId);
            Uye uye = _uyeService.GetById(identityUser.uyeId);
            string rolName = _rolService.GetById(kullanici.rol_id).rol_adi;

            List<Calisma> calismalar = _calismaService.GetListByUyeId(identityUser.uyeDetayId);
            CalismaBilgileri studyInfo = studyInfos(calismalar);

            List<Sinav> sinavlar = _sinavService.GetListByStatus(1);            

            _model = new PanelModel
            {
                userDetail = new Entities.Dtos.UserDetail
                {
                    uyedetay_id = identityUser.uyeDetayId,
                    uye_id = identityUser.uyeId,
                    kullanici_adi = identityUser.kullaniciAdi,
                    kullanici_mail = identityUser.kullaniciMail,
                    tema_id = 1,
                    kayit_tarihi = kullanici.kayit_tarihi,
                    uye_ad = uye.uye_ad,
                    uye_soyad = uye.uye_soyad,
                },
                rolAdi = rolName,
                toplamCalisilanZaman = studyInfo.toplamCalisilanZaman,
                sonCalisilanSinav = studyInfo.sonCalisilanSinav,
                sonCalismaTarihi = studyInfo.sonCalismaTarihi,
                sinavaCalisilanToplamZaman = studyInfo.sinavaCalisilanZaman,
                sinavTarihi = studyInfo.sinavTarihi,
                sonCalisilanDers = studyInfo.sonCalisilanDers,
                derseCalisilanToplamZaman = studyInfo.derseCalisilanZaman,
                derseSonCalisilanZaman = studyInfo.derseSonCalisilanZaman,
                aktifSinavlar = sinavlar                
            };
            return View(_model);
        }
    }
}