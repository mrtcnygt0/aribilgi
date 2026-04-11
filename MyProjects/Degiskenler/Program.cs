using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Değişken Ders Notları:
             * Değişken, bazı verileri bilgisayarın belleğinde (RAM) geçici bir süre bekletmek için kullandığımız yapılardır. İçlerinde bilgiyi program boyunca saklarlar, program sonlandığında bellekten atılırlar. Değişkenler içlerinde değişik türde bilgiler taşıyabilirler. Bir değişkeni tanımlarken, içinde ne tür bir bilgi saklayacağımızı belirtmemiz gerekir.
            Değişken tipleri:
            1- Değer Tipli Değişkenler: byte, int, double, char, bool, struct, enum
            2- Referans Tipli Değişkenler: string, array, class, delegate, interface

            1- Değer Tipli Değişkenler: Bu tip değişkenleriçlerinde veri taşırlar. Belleğin "Stack" bölgesinde yaratılırlar.
                a) Tam sayı tipler:  byte, short, int, long en çok kullanılan tam sayı tiplerdir.
             
             */


            //-----------------------------------------------------------
            //-------------   REFERANS TİPLİ DEĞİŞKENLER   --------------
            //-----------------------------------------------------------

            /*
            Referans tipli değişkenler içinde doğrudan veriyi tutmazlar. Verinin heap bellekteki adresini tutarlar. Yani verinin yerini işaret ederler. Bu nedenle bunlara pointer (işaretçi) de denir. 

            Değişkenin kendisi stack bölgesinde verisi ise heap bölgesindedir.
            */

            string aracModeli = "Sedan";

            Console.WriteLine(aracModeli.Length);

            string metin = aracModeli[0].ToString();
            Console.WriteLine(metin);

            string ilk2Karakter = aracModeli.Substring(0,2);
            Console.WriteLine(ilk2Karakter);

            // Ürün fiyat adet isim
            string urunIsim;
            double urunFiyat;
            int urunAdet;

            urunIsim = "Kalem";
            urunFiyat = 140.75;
            urunAdet = 100;

            Console.WriteLine(urunIsim);
            Console.WriteLine(urunFiyat + " TL");
            Console.WriteLine(urunAdet + " tane");

            Console.Read();

        }
    }
}
