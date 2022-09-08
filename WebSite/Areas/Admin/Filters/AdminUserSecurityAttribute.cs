
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Areas.Admin.Filters
{
    public class AdminUserSecurityAttribute : ActionFilterAttribute
    {


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.GetString("YoneticiRol") == null)
            {
             //   filterContext.Result = new RedirectResult ( "~/HataYonetimi/SayfaHata" );
              filterContext.HttpContext.Response.Redirect("../HataYonetimi/SayfaHata");
                
            }
            //else {
            //    filterContext.HttpContext.Response.Redirect("Anasayfa");
            //}
            base.OnActionExecuting(filterContext);
        }

    }
}