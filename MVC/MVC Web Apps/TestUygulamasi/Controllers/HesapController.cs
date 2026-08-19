using Microsoft.AspNetCore.Mvc;

namespace TestUygulamasi.Controllers
{
    public class HesapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string MesajVer()
        {
            return "Merhaba";
        }

        public double Topla()
        {
            return 155 + 255;
        }

        public IActionResult SonucGoster()
        {
            ViewBag.Toplam = Topla();
            ViewBag.Mesaj = "Mert Can YİĞİT";
            return View();
        }
    }
}
