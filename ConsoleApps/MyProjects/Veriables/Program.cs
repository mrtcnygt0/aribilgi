using System;
using System.Collections;
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

            /*
             
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

            */

            ///////////////////////////////////////////////////////////////////////////////////////
            // ****************************   Kolleksiyonlar   ************************************
            ///////////////////////////////////////////////////////////////////////////////////////
            
            // ** ArrayList **// 
            // Dinamik dizilerdir, her seferinde ArrayListe' e yeni bir üye eklenir. Sınırı yoktur.

            // demirbasListesi = belleğin stack kısmında (heapteki ArrayListin adresini tutar)
            // new ArrayList = belleğin heap kısmında ArrayList oluşturur

            /*
            ArrayList demirbasListesi = new ArrayList();

            demirbasListesi.Add(232);
            demirbasListesi.Add(10.50);
            demirbasListesi.Add("asdasd");
            demirbasListesi.Add('A');
            demirbasListesi.Add(true);

            // Ekrana yazdırırken .ToString kullanmak güvenlik açısından önemlidir. CW harici kullanımlarda ArrayList içerisindeki object değer ekranda gösterilemeyecek karmaşık bir değer olabilir.

            // Array' deki Lenght özelliği ArrayList' te Count ile yapılır.
            // Console.WriteLine(demirbasListesi.Count);
            int elemanSayisi = demirbasListesi.Count;
            // Console.WriteLine(elemanSayisi);

            for (int counter = 0; counter < elemanSayisi; counter++)
            {
                Console.WriteLine(demirbasListesi[counter].ToString());
            }
            // Remove kullanırken verinin tipi şeklinde yazılmalı. 232 değeri "232" olarak yazılırsa 232 değerini silmez.
            demirbasListesi.Remove(232);
            Console.WriteLine(demirbasListesi[0].ToString());
            // RemoveAt = 0. sıradaki veriyi sil
            demirbasListesi.RemoveAt(0);
            // RemoveRange = 0. veriyden başla liste boyutu kadar sil
            demirbasListesi.RemoveRange(0, demirbasListesi.Count);
            // Clear = hepsini sil
            demirbasListesi.Clear();

            */

            ///////////////////////////////////
            //******* DEPO OTOMASYONU *******//
            ///////////////////////////////////
            
            /*
             * 
            ArrayList depoList = new ArrayList();

            depoList.Add("Telefon");
            depoList.Add("Küpe");
            depoList.Add("Çanta");

            Console.WriteLine("====================================");
            Console.WriteLine("***********    DEPO    *************");
            Console.WriteLine("====================================");

            Console.WriteLine("HOŞ GELDİNİZ!");
            Console.WriteLine();

            int secim;
            string ekleUrun;
            string silUrun;
            bool varMi;

            SecimEkrani:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz...");

            Console.WriteLine("> 1) Ürün ekle");
            Console.WriteLine("> 2) Ürün sil");
            Console.WriteLine("> 3) Ürün ara");
            Console.WriteLine("> 4) Ürünleri listele");
            Console.WriteLine();

            secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("*********    ÜRÜN EKLE   ***********");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.Write("Eklemek istediğiniz ürün adını giriniz: ");
                ekleUrun = Console.ReadLine();

                varMi = depoList.Contains(ekleUrun);

                if (!varMi)
                {
                    depoList.Add(ekleUrun);
                    Console.WriteLine(ekleUrun + " başarıyla eklendi.");
                    Console.WriteLine();
                    goto SecimEkrani;
                }
                else
                {
                    Console.WriteLine(ekleUrun + " zaten depoda bulunmaktadır.");
                    Console.WriteLine();
                    goto SecimEkrani;
                }

            }
            else if (secim == 2)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("*********    ÜRÜN SİL    ***********");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.Write("Silmek istediğiniz ürün adını giriniz: ");
                silUrun = Console.ReadLine();
                depoList.Remove(silUrun);
                Console.WriteLine(silUrun + " başarıyla silindi.");
                Console.WriteLine();
                goto SecimEkrani;
            }
            else if (secim == 3)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("*********    ÜRÜN ARA    ***********");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.Write("Aramak istediğiniz ürün adını giriniz: ");
                string araUrun = Console.ReadLine();
                varMi = depoList.Contains(araUrun);
                if (varMi)
                {
                    Console.WriteLine(araUrun + " depoda bulunmaktadır." + " Sıra Numarası: " + depoList.IndexOf(araUrun));
                }
                else
                {
                    Console.WriteLine(araUrun + " depoda bulunamadı.");
                    Console.WriteLine();
                    goto SecimEkrani;
                }

            }
            else if (secim == 4)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("*******    ÜRÜN  LİSTESİ    ********");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("Ürün Sayısı: " + depoList.Count);
                for (int i = 0; i < depoList.Count; i++)
                {
                    Console.WriteLine((i + 1) + "> " + depoList[i]);
                }
                Console.WriteLine();
                goto SecimEkrani;
            }

            Console.ReadKey();

            //-- HashTable --//
            // Tip güvenli değildir, her object değerini alabilir.
            // 2 değer bekler
            // Arama yaparken "key" değeri girilir, dönen veri "value" değeridir.

            Hashtable aracListesi = new Hashtable();
            aracListesi.Add("34 ABC 34", 1500000);
            aracListesi.Add("35 AB 124", 2500000);
            aracListesi.Add("54 SAK 54", 800000);

            Console.WriteLine(aracListesi["35 AB 124"].ToString());

            // HashTable' da döngü için foreach kullanımı daha uygundur.
            // foreach henüz anlatılmadı. ÖRNEK KULLANIM
            foreach (var item in aracListesi.Keys)
            {
                Console.WriteLine(aracListesi[item].ToString());
            }

            // varmı armasını ContainsKey/Value ile yapıyoruz. Bool değer döndürür.
            bool plakaMevcut = aracListesi.ContainsKey("34 XX 333");

            */

            //----- Dictionary -----//
            // HasthTable' ın TypeSafe - Tip Güvenli versiyonudur.
            
            /*
            Dictionary<string,string> enTrSozluk = new Dictionary<string,string>();

            Console.Title = "SÖZLÜK - DICTIONARY";

            enTrSozluk.Add("mouse", "fare");
            enTrSozluk.Add("pen", "tükenmez kalem");
            enTrSozluk.Add("cup", "bardak");
            enTrSozluk.Add("car", "araba");
            enTrSozluk.Add("phone", "telefon");
            enTrSozluk.Add("class", "sınıf");
            enTrSozluk.Add("dictionary", "sözlük");

            string arananKelime = "";
            bool kelimeVarMi = false;
            string sozlukDevamMi = "";


            SozlukDongu:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======================================");
            Console.WriteLine("*********** EN/TR SÖZLÜK *************");
            Console.WriteLine("======================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Gray;
            arananKelime = Console.ReadLine().ToLower();
            kelimeVarMi = enTrSozluk.Keys.Contains(arananKelime);
            if (!kelimeVarMi)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aranan kelime sözlükte bulunamadı!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");

                OlumsuzTercih:
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                sozlukDevamMi = Console.ReadLine().ToUpper();
                if(sozlukDevamMi == "E")
                {
                    Console.ResetColor();
                    Console.Clear();
                    goto SozlukDongu;
                }
                else if (sozlukDevamMi == "H")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GÜLE GÜLE...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Yanlış seçim yaptınız. Lütfen tekrar deneyin!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto OlumsuzTercih;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine("> " + arananKelime + " = " + enTrSozluk[arananKelime]);
                Console.WriteLine("--------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                OlumluTercih:
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                sozlukDevamMi = Console.ReadLine().ToUpper();
                if (sozlukDevamMi == "E")
                {
                    Console.ResetColor();
                    Console.Clear();
                    goto SozlukDongu;
                } 
                else if (sozlukDevamMi == "H")
                {
                    Console.WriteLine();
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("GÜLE GÜLE...");
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("Yanlış seçim yaptınız. Lütfen tekrar deneyin!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto OlumluTercih;
                }
            }

            Console.ReadKey();
            */

            //----- Generic List -----//
            // ArrayList ' in Generic tipinde versiyonudur.

            List<string> malzemeListesi = new List<string>();

            malzemeListesi.Add("Matkap");
            malzemeListesi.Add("Tornavide");
            malzemeListesi.Add("Çekiç");
            malzemeListesi.Add("Lamba");
            malzemeListesi.Add("El Feneri");
            malzemeListesi.Add("Pil");


            List<Student> ogrenciListesi = new List<Student>();

            Student student1 = new Student();
            student1.StudentID = 1;
            student1.NameSurname = "Osman";
            student1.Grade = 3.49;

            ogrenciListesi.Add(student1);

            ogrenciListesi.Add(new Student { StudentID = 1, NameSurname = "Mustafa", Grade = 2.75 });
            ogrenciListesi.Add(new Student { StudentID = 2, NameSurname = "Esra", Grade = 3.2 });
            ogrenciListesi.Add(new Student { StudentID = 3, NameSurname = "Cemile", Grade = 1.85 });
            ogrenciListesi.Add(new Student { StudentID = 4, NameSurname = "Hüsrev", Grade = 4.15 });



            Console.ReadKey();
        }
    }
}
