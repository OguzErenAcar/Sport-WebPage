using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Data
{
    public class WebSiteContext : DbContext
    {
        public WebSiteContext (DbContextOptions<WebSiteContext> options)
            : base(options)
        {
        }

        public DbSet<WebSite.Models.Haberler> Haberler { get; set; }
        public DbSet<WebSite.Models.Slider> Slider { get; set; }
        public DbSet<WebSite.Models.Ligler> Ligler { get; set; }
        public DbSet<WebSite.Models.Puandurumu> Puandurumu { get; set; }
        public DbSet<WebSite.Models.Katagori> Katagori { get; set; }
        public DbSet<WebSite.Models.GenelAyarlar> GenelAyarlar { get; set; }
        public DbSet<WebSite.Models.Users> Users { get; set; }

    
    }
}
