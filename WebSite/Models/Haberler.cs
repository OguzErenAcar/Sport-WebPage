using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Haberler

    {
        [Key]
        public int id { get; set; }
        public String baslik{ get; set; }
        public String icerik{ get; set; }
        public DateTime Eklenmetarih { get; set; }
        public String Resimyolu { get; set; }
        public Nullable <int>  Takimid  { get; set; }


    }
}
