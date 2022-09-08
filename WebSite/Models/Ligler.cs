using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Ligler
    {
        [Key]

        public int id { get; set; }
        public string ligisim { get; set; }
        public string Logoyolu { get; set; }
        
    

    }
}
