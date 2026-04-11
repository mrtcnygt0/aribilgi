using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veriables
{
    struct Student
    {
        public int StudentID;
        public string NameSurname;
        public double Grade;
        public Gender Gender;
    }

    struct Car
    {
        public int CarID;
        public short ProduceYear;

        public double CarPrice;
        public double CarVolume;

        public string CarModel;
        public string CarProducer;
        public Colors CarColor;
    }

    enum Colors
    {
        White=255, 
        Black=0, 
        Blue, 
        Red, 
        Green, 
        Yellow, 
        Gray
    }

    enum Gender
    {
        Male,
        Female,
        Unknown
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            char karakter = 'a';
            string k = "hhhhh";
            char eleman = k[0];

            char cr = (char)169;

            Console.WriteLine(cr);

            bool status = false;

            */


            /*
            Student s1;
            s1.StudentID = 1;
            s1.NameSurname = "Ali AK";
            s1.Grade = 2.88;
            s1.Gender = Gender.Male;
            

            Car car1;
            car1.CarID = 1;
            car1.CarPrice = 1200000;
            car1.CarProducer = "Toyota";
            car1.CarModel = "Corolla";
            car1.CarColor = Colors.Black;
            car1.ProduceYear = 2015;
            car1.CarVolume = 24551.781;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MÜŞTERİ BİLGİLERİ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(">Adı: " + s1.NameSurname);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ARAÇ BİLGİLERİ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(">Araba Numarası: " + car1.CarID);
            Console.WriteLine(">Araba Fiyatı: " + car1.CarPrice + "TL");
            Console.WriteLine(">Araba Yapımcısı: " + car1.CarProducer);
            Console.WriteLine(">Araba Modeli: " + car1.CarModel);
            Console.WriteLine(">Araba Renk: " + car1.CarColor);
            Console.WriteLine(">Araba Yılı: " + car1.ProduceYear);
            Console.WriteLine(">Araba Kilometre: " + car1.CarVolume + "km");

            Console.ResetColor();

            Console.Read();

            */

            Console.ResetColor();

            // ****************************   DİZİLER   ************************************

            // Array : Dizi - İçerisinde aynı tipten birden fazla değeri taşıyabilen yapılardır.
            // Arrayler dinamik bir yapıda değildir. Boyutu sabittir. Veri girildikçe boyutu otomatik artmaz.

            // * Örnek içinde Döngülere (for) değinilmiştir.

            /*
            
            int s01 = 5;
            int s02 = 75;
            int s03 = 45;

            int[] ogrNotlar = new int[10];
            string[] ogrAdlari = { "Mert", "Hasan", "Gamze", "Selim" };
            char[] karakterler = new char[10];

            Student[] ogrenciler = new Student[10];

            ogrNotlar[0] = 25;
            ogrNotlar[1] = 85;
            ogrNotlar[2] = 50;
            ogrNotlar[3] = 60;

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };


            // Dizi içindekileri alfabetik sıralama
            Array.Sort(ogrAdlari);
            // Alfabetik sıralanan diziyi tersine çevirme
            Array.Reverse(ogrAdlari);
            // Array boyutunu değiştirme
            Array.Resize(ref ogrAdlari, 10);
            // Dizideki bu isimdeki verinin hangi indekste olduğunu çekmek
            Array.IndexOf(ogrAdlari, "Mert");
            // Çekilen değeri ekrana yazdırma
            Console.WriteLine(Array.IndexOf(ogrAdlari, "Mert"));

            
            // goto ile yapılan döngü:
            // sayac ile döngünün ilerlemesi ve dizi indexinin artarak yazılması sağlandı.
            int sayac = 0;
        Tekrar:
            Console.WriteLine((sayac+1) +". Öğrencinin ismi: " + ogrAdlari[sayac]);
            sayac++;

            if(sayac < ogrAdlari.Length) goto Tekrar;


            // for ile yapılan döngü:
            for (int i = 0; i < ogrAdlari.Length; i++) 
            {

                Console.WriteLine((i+1) + ". Öğrencinin ismi: " + ogrAdlari[i]);

            }


            sayac = 0;
            int[] isimler = new int[10];
            // Dizileri bu şekilde aktarmak, verileri değil verilerin ramde tutulduğu adresleri aktarır! Diziler referans tiplidir.
            isimler = ogrNotlar;

            isimler[0] = 25;
            //Liste içini temizleme
            Array.Clear(isimler, 0, isimler.Length);

        Tekrar2:
            Console.WriteLine((sayac + 1) + ". Öğrencinin ismi: " + ogrAdlari[sayac]);
            sayac++;

            if (sayac < ogrAdlari.Length) goto Tekrar2;


            // Değer tipli değişkenleriçlerinde doğrudan veriyi tutarlar. Birbirlerine atandaıklarında da içlerindeki verinin kopyasını aktarırlar. Referans tipli değişkenler ise içlerinde veri değil verinin bulunduğu bellek adresini tutarlar. Dolayısıyla birbirlerine atandıklarında, içlerinde tuttukları bellek bölgesinin adresini kopyalamış olurlar. Böylece her 2 referans tipli değişken de aynı bellek adresini işaret eder ve değerini yönetir.
            int sayi1 = 100;
            int sayi2 = 100;

            sayi1 = sayi2;
            sayi2 = 500;

            Console.WriteLine("Sayı1:" + sayi1 + " Sayı2:" + sayi2);


            */

            // =========================================================================================
            // --------------------------    Kütüphane Konsol Otomasyonu    ----------------------------
            // =========================================================================================

            Console.Title = "KÜTÜPHANE OTOMASYONU";

            string bookName;

            //Kitap Dizisi
            string[] books = {
                "1984",
                "Simyacı",
                "Suç ve Ceza",
                "Körlük",
                "Sefiller",
                "Hayvan Çiftliği",
                "Dune",
                "Küçük Prens",
                "Cesur Yeni Dünya",
                "Yeraltından Notlar"
            };


            // Arayüz
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hoş Geldiniz!");
            Console.WriteLine();

            Dongu:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aramak istediğiniz kitap ismini tam yazınız...");
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            bookName = Console.ReadLine();

            // İstenen kitabın indexini alma
            int bookNumber = Array.IndexOf(books, bookName);

            if(Array.IndexOf(books, bookName) == -1)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aradığınız kitap kütüphanemizde bulunmamaktadır...");
                Console.WriteLine("-----------------------------------------------");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Kitap kütüphanemize bulunmaktadır.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Sıra numarası: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Array.IndexOf(books, bookName));
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Farklı bir kitap aramak ister misiniz? E=Evet , H=Hayır");
            Console.ForegroundColor = ConsoleColor.White;
            string devamMi = Console.ReadLine();

            if(devamMi == "e" || devamMi == "E")
            {
                Console.ResetColor();
                Console.Clear();
                goto Dongu;
            } 
            else 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hoşçakalın..."); 
            }


            Console.ReadKey();
        }
    }
}
