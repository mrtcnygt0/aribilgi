using KendimiDeniyorum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KendimiDeniyorum.Controllers
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
            List<Sinav> SinavListesi = new List<Sinav>();

            SinavListesi.Add(new Sinav() { OgrAd = "Mert Can YİĞİT", Tarih = DateTime.Parse("2025-12-12 19:00:00"), Ders = "Matematik", Puan = 78 });
            SinavListesi.Add(new Sinav() { OgrAd = "Ali Veli", Tarih = DateTime.Parse("2025-12-12 19:00:00"), Ders = "Fizik", Puan = 57 });
            SinavListesi.Add(new Sinav() { OgrAd = "Selim Adıbelli", Tarih = DateTime.Parse("2025-12-12 19:00:00"), Ders = "Fizik", Puan = 85 });
            SinavListesi.Add(new Sinav() { OgrAd = "Hakan Karakuş", Tarih = DateTime.Parse("2025-12-12 19:00:00"), Ders = "Türkçe", Puan = 35 });

            return View(SinavListesi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
