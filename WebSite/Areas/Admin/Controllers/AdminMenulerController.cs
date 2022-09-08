using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebSite.Areas.Admin.Filters;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]

    [ServiceFilter(typeof(AdminUserSecurityAttribute))]
    public class AdminMenulerController : Controller
    { 
        private readonly WebSiteContext db;

        public AdminMenulerController(WebSiteContext context)
        {

            db = context;
        }
        
        public IActionResult Anasayfa()
        {

            return View();
        }
        public IActionResult GenelAyarlar()
        {
            return View();
        }




        public IActionResult MenuY()
        {
            var katagoriler = db.Katagori.OrderBy(a => a.id);
            return View(katagoriler);
        }


        [HttpGet]
        public IActionResult Menusil(int id)
        {
           
             var menu = db.Katagori.Where(a => a.id == id).FirstOrDefault();
            var bool_ = db.Katagori.Where(a => a.Parentid == menu.id).Any();
            if (bool_)
            {
                return Json(new { Result = true, message = "Katagorinin ilk alt katagorilerini silmeniz gerekir.." });
            }
            else 
            {
               db.Attach(menu);
                db.Remove(menu);
                db.SaveChanges();
                return Json(new { Result = true, message = "Silindi " });
            }


            

        }


        [HttpPost]
        public IActionResult MenuKaydet([FromBody] Katagori data)
        { 
            try
            {
                 if (db.Katagori.Where(a => a.id == data.id).Any()==false)
                {
                    db.Katagori.Add(data);
                }
                else { 
                db.Katagori.Where(a => a.id == data.id).FirstOrDefault().katagori= data.katagori;
                db.Katagori.Where(a => a.id == data.id).FirstOrDefault().Link = data.Link;
                db.Katagori.Where(a => a.id == data.id).FirstOrDefault().Parentid = data.Parentid;
                db.Katagori.Where(a => a.id == data.id).FirstOrDefault().Aktifmi = data.Aktifmi;
                 
                }
                db.SaveChanges();

                return Json(new { Result = true, Message = "Kaydedildi "});

            }
            catch (Exception e)
            {
                return Json(new {   Message = "Bir hata oluştu. " + e.Message });
            }

        }
         
 ////////////////////////////////////////////////////////////////
          public IActionResult HaberY( )
        {
            return View();
        }
        public IActionResult HaberListe()

        {
            
            var Haberler = db.Haberler.OrderByDescending(a => a.Eklenmetarih);

            return View(Haberler);
        }

        [HttpPost]
        public IActionResult HaberYonetimi([FromBody] Haberler data)
        {
            
            try
            {
                String baslik = data.baslik;
                String icerik = data.icerik;
                String Resimy = data.Resimyolu;
                //Nullable<int> Takimid = data.Takimid;
                data.Eklenmetarih = DateTime.Now;
                data.id = db.Haberler.OrderByDescending(u => u.id).FirstOrDefault().id+1;

                if (String.IsNullOrEmpty(baslik)&& String.IsNullOrEmpty(icerik)&& String.IsNullOrEmpty(Resimy))
                {
                    return Json(new { Result = true, Message = "Haber eklenemedi bilgiler eksik." });

                }
                db.Haberler.Add(data);
                db.SaveChanges();

                return Json(new { data, Message = "Haber eklendi" });
            }
            catch (Exception e)
            {
                 
                return Json(new { Result = true, Message = "Bir hata oluştu. " +e.Message });

            }

             
        }
        [HttpGet]
        public IActionResult HaberSil(int id)

        { 
                 System.Diagnostics.Debug.WriteLine(id);
            try {
                var haber = db.Haberler.Where(a => a.id == id).FirstOrDefault();
                 
                db.Remove(haber);
                db.SaveChanges();
                return Json(new { Result = true, message = "Silindi " });
            }
            catch (Exception e)
            {

                return Json(new { Result = true, Message = "Bir hata oluştu. " + e.Message });

            }
        }



        ////////////////////////////////////////////////////////////////
        public IActionResult SliderY()
        {

            return View();
        }
        public IActionResult SliderListe() {

            var Sliders = db.Slider.OrderByDescending(a => a.Eklenmetarihi);

            return View(Sliders);
        }



        [HttpPost]
        public IActionResult SliderYonetimi([FromBody] Slider data)
        {

            try
            {
                String baslik = data.Baslik;
                String Resimy = data.Resim;
                data.Eklenmetarihi = DateTime.Now;
                data.id = db.Slider.OrderByDescending(u => u.id).FirstOrDefault().id + 1;

                if (String.IsNullOrEmpty(baslik) && String.IsNullOrEmpty(Resimy))
                {
                    return Json(new { Result = false, Message = "Haber eklenemedi bilgiler eksik." });

                }
                db.Slider.Add(data);
                db.SaveChanges();

                return Json(new {  Message = "Slider eklendi" });
            }
            catch (Exception e)
            {

                return Json(new { Result = false, Message = "Bir hata oluştu. " + e.Message });

            }


        }
        [HttpGet]
        public IActionResult SliderSil(int id)

        {
            System.Diagnostics.Debug.WriteLine(id);
            try
            {
                var Slider = db.Slider.Where(a => a.id == id).FirstOrDefault();

                db.Remove(Slider);
                db.SaveChanges();
                return Json(new { Result = true, message = "Silindi " });
            }
            catch (Exception e)
            {

                return Json(new { Result = true, Message = "Bir hata oluştu. " + e.Message });

            }
        }




    }
}
