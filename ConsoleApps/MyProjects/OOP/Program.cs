using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Renkler
    {
        None,
        Kırmızı,
        Sarı,
        Mavi,
        Siyah,
        Beyaz
    }
    class Araba
    {

    }

    public class Product
    {
        public int ProductId;
        public string ProductName;
        public string ProductDescription;
        public string ProductCategory;
        public double ProductPrice;
        public Renkler ProductColor;
        public string ProductSize;

        public void KDVHesapla()
        {
            Console.WriteLine($"KDV Tutarı: {ProductPrice * 0.20}");
        }

        public void KDVHesapla(double kdvOrani)
        {
            Console.WriteLine($"KDV Tutarı: {ProductPrice * kdvOrani}");
        }
    }

    public class Ogrenci
    {
        public int OgrId;
        public string SinifSunbe;
        public string AdSoyad;
        public double NotOrtalamasi;
        public DateTime KayitTarihi;
        public double vizeNotu;
        public double finalNotu;

        public void NotOrtHesapla()
        {
            NotOrtalamasi = (vizeNotu * 0.40) + (finalNotu * 0.60);
            Console.WriteLine($"Not Ortalamanız: {NotOrtalamasi}");
        }

        public void NotOrtHesapla(double vize, double final)
        {
            NotOrtalamasi = (vize * 0.40) + (final * 0.60);
            Console.WriteLine($"Not Ortalamanız: {NotOrtalamasi}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun = new Product();
            urun.ProductId = 1;
            urun.ProductName = "Laptop";
            urun.ProductDescription = "Asus Laptop";
            urun.ProductPrice = 5000;
            urun.ProductColor = Renkler.Mavi;
            urun.ProductSize = "15 inch";
            urun.ProductCategory = "Kırtasiye";

            Product urun2 = new Product();
            Console.WriteLine("Ürünün Adı Giriniz: ");
            urun2.ProductName = Console.ReadLine();
            Console.WriteLine("Ürünün Açıklamasını Giriniz: ");
            urun2.ProductDescription = Console.ReadLine();
            Console.WriteLine("Ürünün Fiyatını Giriniz: ");
            urun2.ProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------");
            Console.WriteLine($"Girdiğiniz Ürün: Adı: {urun2.ProductName} , Açıklama: {urun2.ProductDescription} , Fiyat: {urun2.ProductPrice}");

            Console.WriteLine(urun.ProductName);
            urun.KDVHesapla();
            urun.KDVHesapla(0.20);

            // --------- //

            Ogrenci ogrenci1 = new Ogrenci();

            Console.WriteLine("Vize notunu giriniz: ");
            ogrenci1.vizeNotu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final notunu giriniz: ");
            ogrenci1.finalNotu = Convert.ToDouble(Console.ReadLine());

            ogrenci1.NotOrtHesapla(ogrenci1.vizeNotu,ogrenci1.finalNotu);



        }
    }
}
