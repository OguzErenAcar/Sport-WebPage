using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using WebSite.Data;
using System.Text;

namespace WebSite.Controllers
{
    public class PuanDurumuController : Controller
    {
        private readonly WebSiteContext db;
        private HtmlAgilityPack.HtmlDocument dokuman;
        System.Text.EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
        
        public PuanDurumuController(WebSiteContext context)
        {
            Encoding.RegisterProvider(provider);
            db = context;
            
            sitebaglanti("https://www.tff.org/default.aspx?pageID=198");
            TabloyuGuncelle("//*[@id='ctl00_MPane_m_198_1890_ctnr_m_198_1890_grvACetvel_ctl",
              new String[]{ "_lnkTakim']", "_lblOyun']", "_Label4']", "_lblKazanma']", "_lblPuan']", "_Label1']", "_Label2']", "_Label5']", "_Label3']" });
        }


        public IActionResult Ligler(int id )
        {
            return View(id);
        }






        public IActionResult Puandurumu()
        {

           var tablo = db.Puandurumu.OrderBy(a=>a.id);

            return View(tablo);
        }
        public void sitebaglanti(String Url)
        {
            
            Uri url = new Uri(Url);
            WebClient client = new WebClient();
            client.Encoding = Encoding.GetEncoding("iso-8859-9");
            string html = client.DownloadString(url);
            dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);


        }
        public void TabloyuGuncelle(String str_, String[] dizi_str_)
            {
            string str =str_;
            String[] dizi_str =dizi_str_;
            String[] dizi = new string[9];

          //  for (int i = 1; i < 22; i++)
          //  {
          //      string sayi = i.ToString();
          //      if (i<10)
          //      {
          //          sayi = "0" + sayi;
          //      }
           
          //  for (int j = 0; j< 9; j++)
          //  {
          //         // System.Diagnostics.Debug.WriteLine("\"" + str + sayi + dizi_str[j] + "\"");


          //      HtmlNodeCollection baslik =  dokuman.DocumentNode.SelectNodes(str +sayi+dizi_str[j]);
          //      foreach (var item in baslik)
          //      {

          //           //   System.Diagnostics.Debug.Write(dizi[j]);
          //              dizi[j] = item.InnerText;

          //      }
          //  }
          //var tablo = db.Puandurumu;
          //      foreach (var takim in tablo.Skip(i-1).Take(1))
          //      {
                  
          //      takim.Takimisim=dizi[0];
          //      takim.OynananMac = dizi[1];
          //      takim.Galibiyet = dizi[2];
          //      takim.Beraberlik = dizi[3];
          //      takim.Malubiyet = dizi[4];
          //      takim.AtilanGol = dizi[5];
          //      takim.YenilenGol = dizi[6];
          //      takim.Avaraj = dizi[7];
          //      takim.Puan = dizi[8];
                   
          //      }
                

          //  }
            db.SaveChanges();
            
        }
    }

}
