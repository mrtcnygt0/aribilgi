using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////
            ////             OPERATORLER             ////
            /////////////////////////////////////////////
            /// 1. Aritmetik Operatörler : + , - , * , / , % , ( , )
            /*
            Sayıların arasına konan ve matematiksel işlem yapılmasını sağlayan operatörlerdir. Sonuç döndürürler.
            */
            /// 2. Mantıksal Karşılaştırma Operatörleri : < , > , <= , >= , == , !=
            /*
            Karşılaştırma işlemleri gerçekleştirirler. True, False döndürürler.
            */
            /// 3. Atama Operatörü : =
            /*
            Sağındaki bilgiyi sol tarafa aktarır. Örn: x= 5; sonuc = a+b;
            */
            /// 4. Birleşik Operatörler : ++ , -- , += , -= ,  *= , /=
            /*
            Bazı işlemlerin kısa tanımı için kullanırlar.
            Örnek:
            int sayac = 0;
            sayac = sayac + 1;
            sayac += 1;
            sayac -= 1;
            sayac++; // 1 artıran operatör.
            sayac--; // 1 eksilten operatör.
            */
            /// 5. Metin Birleştirme Operatörü : +
            /*
            + işaretinin sağındaki ya da solundaki veri string ise o zaman metin birleştirme işlemi yapar ve string değer üretir. Her iki değer sayısal ise aritmetik toplama yapar ve toplama sonucunu geriye uygun tipte döndürür.
            Örnek: 
            string a = "ali";
            string b = "veli";
            c = a + b;
            c değişkeni, "aliveli" çıktısını verir.

            string kod = "ABC" + 123
            kod, ABC123 çıktısını verir.

            Random rnd = new Random(); // Random sınıfı, rastgele sayı üretmek için kullanılır.
           
            string password = "P" + rnd.Next(1000000,9999999) + "!";

            */
            

            Console.ReadKey();
        }
    }
}
