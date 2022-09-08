using WebSite.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

 
 
    public class KatagoriComponent : ViewComponent
    {

        private readonly WebSiteContext db;

        public KatagoriComponent(WebSiteContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var katagoriler= db.Katagori.Where(a => a.Aktifmi).OrderBy(a => a.id);


        return View("Katagoriler", katagoriler); 
        }
    }
 
