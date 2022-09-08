using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data;
using WebSite.Models;
namespace WebSite.Controllers
{
    public class SliderController : Controller
    {

        private readonly WebSiteContext db;


        public SliderController(WebSiteContext context)
        {

            db = context;
        }


        public IActionResult Slider()
        {
 

            return View( );
        }


        public IActionResult Fiksturtable()
        {

            return View();
        }


    }
}
