using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Slider


    {
        [Key]

        //Nullable lara dikkat 
        public int id { get; set; }
        public String Baslik{ get; set; }
        public String Resim{ get; set; }
        public DateTime Eklenmetarihi { get; set; }
        public String Link { get; set; } 
       
    }
}
