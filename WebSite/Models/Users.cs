using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    
    public class Users
    {
        [Key]
      
        public string Parola { get; set; }
        public string Email { get; set; }

        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KucukResimYolu { get; set; }
        public DateTime EklenmeTarih { get; set; }
        public int Rol { get; set; }

        

    }
}
