using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////
            ////           ** DÖNGÜLER **            ////
            /////////////////////////////////////////////
            /// Birden fazla kere çalışması gereken kodları tekrar tekrar yazmak yerine bu kodu istedğimiz kadar çalıştırmayı sağlayan yapılara döngü denir. Bir döngü ya belli bir adette ya da belli bir şartın sağlanması durumunda çalışacak şekilde programlanabilir.


            /* YANLIŞ YÖNTEM
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
            */

            /// ****** 1) CUSTOM ******* ///
            int sayac = 1;
        tekrar:
            Console.WriteLine(sayac);
            sayac++;
            if(sayac < 101)
            {
                goto tekrar;
            }

            /// ************************ ///

            /// ****** 2) FOR ******* ///
            // İşlemin belirli bir adette yapılması istenildiğinde tercih edilen yöntemdir.

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++) 
            {
                if ( i%3 == 0 )
                Console.WriteLine(i);
            }

            // Girilen string değerinin karakterlerini alt alta yazan örnek
            Console.Write("İsminizi girin: ");
            string kelime = Console.ReadLine();
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.WriteLine(kelime[i]);
            }

            string[] iller = {"İstanbul","Ankara","İzmir","Adana","Mersin","Hakkari","Trabzon" };

            for (int i = 0;i < iller.Length; i++)
            {
                Console.WriteLine(iller[i]);
            }

            /// ************************ ///

            /// ****** 3) FOREACH ******* ///
            // Bir koleksiyondaki elemanların her biri için ayrı ayrı tek tek çalışması gereken bir işlem olduğunda tercih ettiğimi döngü yapısıdır.

            foreach (string item in iller)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----   SÖZLÜK   -----");
            Dictionary<string, string> enTrSozluk = new Dictionary<string, string>();

            enTrSozluk.Add("mouse", "fare");
            enTrSozluk.Add("pen", "tükenmez kalem");
            enTrSozluk.Add("cup", "bardak");
            enTrSozluk.Add("car", "araba");
            enTrSozluk.Add("phone", "telefon");
            enTrSozluk.Add("class", "sınıf");
            enTrSozluk.Add("dictionary", "sözlük");

            foreach (string words in enTrSozluk.Keys)
            {
                // Console.WriteLine(words + " : " + enTrSozluk[words]);
                Console.WriteLine($"{words} : {enTrSozluk[words]}");
            }

            /// ************************ ///

            /// ****** 3) WHILE ******* ///
            // Eğer döngünün çalışması ya da durması bir koşula bağlı ise while yapısını tercih ederiz.

            /*
            while (true)
            {
                // TODO: While ile Hesap Makinesi buraya monte edilecek.
                Console.WriteLine("Çalışıyor...");
            }
            */

            // while : ilk çalışmada bile koşul sağlanıyor mu diye kontrol eder.
            int adet = 0; 
            while(adet < iller.Length)
            {
                Console.WriteLine(iller[adet]);
                adet++;
            }

            // do-while : ilk çalışmada do içini çalıştırır, tekrar çalışmak için while koşuluna bakar.
            /*
            string cevap2 = "";
            do 
            {
                //TODO:Hesap makinesi buraya monte edilecek.
                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                cevap2 = Console.ReadLine().ToLower();
            } 
            while (cevap2=="e");
            */

            Console.ReadKey();
        }
    }
}
