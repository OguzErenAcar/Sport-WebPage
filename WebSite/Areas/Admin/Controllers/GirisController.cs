using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebSite.Areas.Admin.Filters;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GirisController : Controller
    {
        private readonly WebSiteContext db;

        public GirisController(WebSiteContext context)
        {
            db = context;
        }
        public IActionResult Giris()
        {
            return View();
        }


        [HttpPost]
        public JsonResult GirisSorgula([FromBody] Users data)
        {
            try
            {
                string Email = data.Email;
                string Parola = data.Parola;

                if (String.IsNullOrEmpty(Parola) && String.IsNullOrEmpty(Email))
                {
                    return Json(new { Result = false, Message = "Kullanıcı Adınızı ve Şifrenizi Girmediniz!" });
                }
                else if (String.IsNullOrEmpty(Email))
                {
                    return Json(new { Result = false, Message = "Kullanıcı Adınızı girmediniz!" });
                }
                else if (String.IsNullOrEmpty(Parola))
                {
                    return Json(new { Result = false, Message = "Şifrenizi Girmediniz!" });
                }
                else
                {
                    SHA1 sha1 = new SHA1CryptoServiceProvider();
                    string sifreli_Parola= Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(Parola)));
                  //  System.Diagnostics.Debug.Write(sifreli_Parola);
                    var kullanici = db.Users.FirstOrDefault(x => x.Email == Email && x.Parola == sifreli_Parola && x.Rol == 1);
                    if (kullanici == null) return Json(new { Result = false, Message = "Kullanıcı Adınızı ya da Şifreyi hatalı girdiniz!" });


                    //Güvenlik açısından bilgileri şifreleyerek saklamamız daha doğru bir yöntemdir.
                    //Asp.Net Membership yapısı, bu güvenliği sunmaktadır.

                    HttpContext.Session.SetInt32("Kullanici_ID", kullanici.id); // Yeni bir session oluşturma.
                    HttpContext.Session.SetString("Ad", kullanici.Ad);
                    HttpContext.Session.SetString("Soyad", kullanici.Soyad);
                    HttpContext.Session.SetString("Resim", kullanici.KucukResimYolu);
                    HttpContext.Session.SetInt32("Rol", kullanici.Rol);



                    HttpContext.Session.SetInt32("KullaniciRol", kullanici.Rol);
                    HttpContext.Session.SetInt32("YoneticiRol", kullanici.Rol);



                    //Burada eğer, kullanıcı bilgileri, sistemde eşleşirse, geriye girişin başarılı
                    //olduğuna dair bir mesaj ve 3 saniye sonra, ana sayfaya yönlendirecek bir
                    //javascript kodu ekliyoruz.        
                    return Json(new { Result = true, Message = "Başarıyla Giriş Yaptınız. Yönlendiriliyorsunuz...", url = "AdminMenuler/Anasayfa" });
                    // return "Başarıyla Giriş Yaptınız. Yönlendiriliyorsunuz...<script type='text/javascript'>setTimeout(function(){window.location='/Admin/Giris/AnaSayfa'},2000);</script>";
                }
            }
            catch (Exception ex)
            {
                return Json(new { Result = false, Message = ex.Message });
            }
        }
     
        public IActionResult OturumuKapat()
        {
            HttpContext.Session.Clear(); // Tüm sessionları temizle
            return View("Giris");
        }

      
    }


}
