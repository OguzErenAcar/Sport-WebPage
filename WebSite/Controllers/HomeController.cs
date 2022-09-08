using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebSiteContext db;

      

        public HomeController(ILogger<HomeController> logger, WebSiteContext context)
        {
            _logger = logger;
            db = context;


        }
        public IActionResult Anasayfa()
        {

            ViewBag.sonHaberler = db.Haberler.OrderByDescending(a=>a.id).Take(6);
            ViewBag.Sliderhaber = db.Slider.OrderByDescending(a => a.Eklenmetarihi);

            return View();
        }
      

        public IActionResult Hakkimizda()
        {
            return View();
        }
        public IActionResult İletisim()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
           
        }
     


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
