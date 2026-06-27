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
    class Car
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
            /*
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

            */

            Console.WriteLine("--------------");

            Kamyon kamyon1 = new Kamyon();
            kamyon1.SetFiyat(-1000);
            kamyon1.Sat();
            Console.WriteLine(kamyon1.GetFiyat());

            Otobus otobus1 = new Otobus();
            otobus1.SetFiyat(200000);
            otobus1.Sat();

            Motosiklet motosiklet1 = new Motosiklet();
            motosiklet1.marka = "Honda";
            motosiklet1.Listele();

            Otomobil otomobil1 = new Otomobil();
            otomobil1.SetFiyat(50000);
            otomobil1.Sat();

            Ucak ucak1 = new Ucak();
            ucak1.marka = "Boeing";
            ucak1.Kirala();

            //Polymorphism: Ucak sınıfında tanımlanan Sat() metodunu, Ucak sınıfında kendine özel olarak değiştirerek kullanabilmesi durumudur.
            ucak1.Sat();
            otomobil1.Sat();
            otobus1.Sat();

            Console.WriteLine("---------------------");

            otobus1.marka = "Mercedes";
            otobus1.model = "Travego";
            otobus1.uretimYili = 2020;

            // Static method: Sınıf adıyla çağrılır, nesne örneği oluşturmaya gerek yoktur.
            Tasit.BilgiVer(otobus1);

            Console.WriteLine("-------------------");

            // İstenirse otobus1 nesnesinin bilgilerini string olarak döndüren ToString() metodunu override ederek kullanabiliriz.
            otobus1.ToString();

            // ----------------------------------------
            /*
            
            OOP: Object Oriented Programming (Nesne Yönelimli Programlama)

            C#' ta uygulamada kullanılacak nesneleri (ürün, müşteri, araç vb.) programa tanımlamak için sınıflar (class) oluşturulur. 
                1. Sınıf (Class): Nesnelerin özelliklerini ve davranışlarını tanımlayan bir şablondur. 
                    Örneğin: Product, Ogrenci, Car, Otobus, Motosiklet, Otomobil, Ucak gibi sınıflar oluşturulabilir.
                   Class bir şablondur, bilgi tutmaz. Class' tan bir nesne örneği belleğe çıkartılır ve o veriler bu nesne örneğine girlir. 
                   Class' tan birden fazla nesne örneği oluşturulabilir.
    
                2. Nesne (Object): Sınıflardan oluşturulan somut örneklere nesne denir. 
                    Örneğin: urun1, ogrenci1, kamyon1 gibi nesneler oluşturulabilir.
    
                3. Encapsulation (Kapsülleme): Verilerin ve metodların bir sınıf içinde gizlenmesi ve sadece belirli yollarla erişilmesi prensibidir. 
                   Class içerisinde doğrudan değer atanmaması gereken alanlara (field) ya da değerin kontrol edilerek atanması gereken durumlarda, ilgili alanı
                   kapsülleyerek kontrollü kullanım sağlarız. Ya tamamen erişime kapatırız (private) ya da kontrollü giriş yaparız.
                    Örneğin: Kamyon sınıfında fiyat bilgisini private olarak tanımlayıp, sadece SetFiyat ve GetFiyat metodlarıyla erişim sağlanması.
    
                4. Inheritance (Kalıtım): Bir sınıfın başka bir sınıftan özelliklerini ve davranışlarını miras almasıdır. 
                    Örneğin: Otobus, Motosiklet, Otomobil ve Ucak sınıflarının ortak özelliklerini taşıyan bir Tasit sınıfından kalıtım alması.
    
                5. Polymorphism (Çok Biçimlilik): Bir nesnenin ata sınıfından devraldığı bir metodu aynen kullanabilrmesi ya da kendine
                   özel olarak değiştirerek kullanabilmesi durumudur. 
                    Örneğin: Tasit sınıfında tanımlanan Sat() metodunun, Otobus, Motosiklet, Otomobil ve Ucak sınıflarında farklı şekillerde uygulanması.
                   Bir nesne hem kendisi gibi hem de duruma göre ata sınıfı davranabilir. Buna Polymorphism denir. 
                   Polymorphism sayesinde, bir nesne hem kendi sınıfına ait özellikleri ve davranışları sergileyebilir, hem de ata sınıfının özelliklerini ve davranışlarını sergileyebilir.
                   Bit ata sınıf içerisinde tanımlanan bir metodun, alt sınıflarda ezilerek özelleştirilebilmesi isteniyor ise ilgili metodun "virtual" olark işaretlenmesi gerekir. 
                   Alt sınıfta ise bu metod ezilirken "override" keyword' ü kullanır.
                    Örnek: public override string ToString() {}
            */
        }
    }
}
