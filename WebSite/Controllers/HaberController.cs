using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data;

namespace WebSite.Controllers
{
    public class HaberController : Controller
    {
         
        private readonly WebSiteContext db;



        public HaberController(  WebSiteContext context)
        { 
            db = context;


        }
        
        public IActionResult HaberDetay(int id)
        { 
             var haber = db.Haberler.FirstOrDefault(a => a.id == id);

            return View(haber);
        }



        public IActionResult Haberler(int id)
        {
            return View(id);
        }

        [HttpPost]
        public JsonResult Getnews(int id)
        { 
            try
            {
                if(id==0){ 
   
                   var haberler = db.Haberler.OrderByDescending(a => a.Eklenmetarih);
                return Json(new { gelendata = haberler, Result = true, Message = "Başarılı" });
                }
                else   
                { 
                   var haberler1 = db.Haberler.Where(a => a.Takimid == id).OrderByDescending(a => a.Eklenmetarih);
                    return Json(new { gelendata = haberler1, Result = true, Message = "Başarılı" });
                }

               
            }
            catch (Exception ex)
            {
              
                return Json(new { Result = false, Message = ex.Message });
            }


        }


    }
}
