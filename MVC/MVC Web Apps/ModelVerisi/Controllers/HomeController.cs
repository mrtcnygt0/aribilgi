using Microsoft.AspNetCore.Mvc;
using ModelVerisi.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ModelVerisi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string username = "Mert Can YİĞİT";

            return View("Index", username);
        }

        public IActionResult Privacy()
        {
            DateTime tarih = DateTime.Now;
            return View(tarih);
        }

        public IActionResult Urunler()
        {
            List<Urun> UrunListesi = new List<Urun>();
            UrunListesi.Add(new Urun() { UrunAd = "Domates", Marka="ABC", Model="Pembe", Fiyat=35});
            UrunListesi.Add(new Urun() { UrunAd = "Mouse", Marka = "LOGITECH", Model = "G300", Fiyat = 1250 });
            UrunListesi.Add(new Urun() { UrunAd = "Klavye", Marka = "STEELSERIES", Model = "X130", Fiyat = 2540 });
            UrunListesi.Add(new Urun() { UrunAd = "Patates", Marka = "ABC", Model = "Köy", Fiyat = 75 });
            UrunListesi.Add(new Urun() { UrunAd = "Kulaklık", Marka = "HYPERX", Model = "Z100", Fiyat = 5740 });
            UrunListesi.Add(new Urun() { UrunAd = "Bulaşık Deterjanı", Marka = "Domestos", Model = "Mintaz", Fiyat = 335 });
            UrunListesi.Add(new Urun() { UrunAd = "Ekmek", Marka = "Taş Fırın", Model = "Trabzon Ekmeği", Fiyat = 180 });
            UrunListesi.Add(new Urun() { UrunAd = "Ayakkabı", Marka = "Nixe", Model = "Keko", Fiyat = 500 });
             
            return View("Urunler" , UrunListesi);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
