using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Katagori
    {

        [Key]
        public int id { get; set; }
        public string katagori { get; set; }
        public bool Aktifmi { get; set; }
        public string Link { get; set; }
        public Nullable<int> Parentid { get; set; }
    }
}
