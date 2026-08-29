using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SatisFormu.Controllers
{
    public class SatisController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, double> urunler = UrunYukle();

            ViewBag.urunler = urunler;


            /* Fiyat verilmeden yapılan ürün listesi
            List<string> urunler = new List<string>();
            urunler.Add("Çikolata");
            urunler.Add("Bisküvi");
            urunler.Add("Kraker");
            urunler.Add("Ekmek");
            urunler.Add("Yumurta");
            */

            ViewBag.urunListesi = new SelectList(urunler.Keys, "Çikolata");

            return View();
        }

        private static Dictionary<string, double> UrunYukle()
        {
            Dictionary<string, double> urunler = new Dictionary<string, double>();
            urunler.Add("Çikolata", 10);
            urunler.Add("Bisküvi", 12);
            urunler.Add("Kraker", 20);
            urunler.Add("Ekmek", 20);
            urunler.Add("Yumurta", 5);
            return urunler;
        }

        [HttpPost]
        public IActionResult Hesapla(string urunAd, double miktar)
        {
            Dictionary<string, double> urunListesi = UrunYukle();
            double fiyat = urunListesi[urunAd];
            double tutar = miktar * fiyat;
            double kdvTutar = tutar * 0.2;

            ViewBag.fiyat = fiyat;
            ViewBag.tutar = tutar;
            ViewBag.kdvTutar = kdvTutar;
            ViewBag.urunAd = urunAd;
            ViewBag.mikar = miktar;
            return View();
        }

    }
}
