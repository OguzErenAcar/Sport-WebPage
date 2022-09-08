using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Puandurumu
    {

        [Key]

        public int    id          { get; set; }
        public string Takimisim   { get; set; }
        public string OynananMac  { get; set; }
        public string Galibiyet   { get; set; }
        public string Beraberlik  { get; set; }
        public string Malubiyet   { get; set; }
        public string AtilanGol   { get; set; }
        public string YenilenGol  { get; set; }
        public string Avaraj      { get; set; }
        public string Puan        { get; set; }

    }
}
