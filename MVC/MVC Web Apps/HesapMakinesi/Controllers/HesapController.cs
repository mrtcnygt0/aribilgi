using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices;

namespace HesapMakinesi.Controllers
{
    public class HesapController : Controller
    {
        public string kullaniciAdi = "Mert Can";

        public void OprtYukle(string oprt) 
        {
            List<string> oprtList = new List<string>();
            oprtList.Add("+");
            oprtList.Add("-");
            oprtList.Add("*");
            oprtList.Add("/");
            ViewBag.oprt = new SelectList(oprtList, oprt);
        }

        public IActionResult Index()
        {
            ViewBag.kullanici = kullaniciAdi;
            OprtYukle("+");

            return View();
        }
         
        [HttpPost]
        public IActionResult Hesapla(double sayi1, double sayi2, string oprt)
        {
            string sonuc = "0";

            switch (oprt)
            {
                case "+":
                    sonuc = Convert.ToString(sayi1 + sayi2);
                    break;
                case "-":
                    sonuc = Convert.ToString(sayi1 - sayi2);
                    break;
                case "*":
                    sonuc = Convert.ToString(sayi1 * sayi2);
                    break;
                case "/":
                    if (sayi2 > 0)
                    {
                        sonuc = Convert.ToString(sayi1 / sayi2);
                    }
                    else
                    {
                        sonuc = "0";
                    }
                    break;
                default:
                    break;
            }

            OprtYukle(oprt);

            ViewBag.sonuc = sonuc;
            ViewBag.sayi1 = sayi1;
            ViewBag.sayi2 = sayi2;
            ViewBag.kullanici = kullaniciAdi;
            return View("Index");
        }
    }
}
