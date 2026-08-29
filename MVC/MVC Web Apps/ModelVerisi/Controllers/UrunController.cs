using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelVerisi.Models;

namespace ModelVerisi.Controllers
{
    public class UrunController : Controller
    {
        // GET: UrunController
        public ActionResult Index()
        {
            List<Urun> UrunListesi = new List<Urun>();
            UrunListesi.Add(new Urun() { UrunAd = "Domates", Marka = "ABC", Model = "Pembe", Fiyat = 35 });
            UrunListesi.Add(new Urun() { UrunAd = "Mouse", Marka = "LOGITECH", Model = "G300", Fiyat = 1250 });
            UrunListesi.Add(new Urun() { UrunAd = "Klavye", Marka = "STEELSERIES", Model = "X130", Fiyat = 2540 });
            UrunListesi.Add(new Urun() { UrunAd = "Patates", Marka = "ABC", Model = "Köy", Fiyat = 75 });
            UrunListesi.Add(new Urun() { UrunAd = "Kulaklık", Marka = "HYPERX", Model = "Z100", Fiyat = 5740 });
            UrunListesi.Add(new Urun() { UrunAd = "Bulaşık Deterjanı", Marka = "Domestos", Model = "Mintaz", Fiyat = 335 });
            UrunListesi.Add(new Urun() { UrunAd = "Ekmek", Marka = "Taş Fırın", Model = "Trabzon Ekmeği", Fiyat = 180 });
            UrunListesi.Add(new Urun() { UrunAd = "Ayakkabı", Marka = "Nixe", Model = "Keko", Fiyat = 500 });

            return View(UrunListesi);
        }

        // GET: UrunController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UrunController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UrunController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
