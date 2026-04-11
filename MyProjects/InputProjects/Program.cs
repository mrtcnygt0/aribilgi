using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InputProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 0;
            int b = 0;
            int toplam = 0;
            string cevap = "H";
            do
            {
                try
                {
                    Console.WriteLine("================  - TOPLAMA UYGULAMASI -  ================");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("LÜTFEN İLK SAYIYI GİRİN: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("LÜTFEN İKİNCİ SAYIYI GİRİN: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    toplam = a + b;
                    Console.WriteLine();
                    Console.WriteLine("======================  - SONUÇ -  =======================");
                    Console.WriteLine();
                    Console.WriteLine(a + " + " + b + " = " + toplam);

                    Console.WriteLine("Tekrar işlem yapmak ister misiniz? Evet=E , Hayır=H");
                    cevap = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Beklenmeyen bir hata meydana geldi! Lütfen tekrar deneyin...");
                    Console.Clear();
                }

            } while (cevap!="H" && cevap!="h");
            {
                Console.WriteLine();
                Console.WriteLine("GÜLE GÜLE");

            }
            */

            // Ekrandan alınan n tane sayının ortalamasını veren program

            int notlar = 0;
            double toplamm = 0;
            string not;
            int deger;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ekrandan Alınan n Tane Notun Ortalamasını Veren Program");
            Console.WriteLine("---------------------------------");

        Dongu:
            Console.WriteLine();
            Console.Write("Notu girin: ");
            not = Console.ReadLine();
            if (not.Length > 0)
            {
                deger = Convert.ToInt32(not);
                if (deger>0 || deger<100)
                {
                    try
                    {
                        toplamm += Convert.ToDouble(not);
                        notlar++;
                        goto Dongu;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Yanlış değer girildi. Lütfen tekrar deneyin!");
                        goto Dongu;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir not değeri giriniz...");
                }
                
            }
            else
            {
                Console.WriteLine("------------");
                Console.WriteLine("Ortalama: " + toplamm/notlar);
                Console.WriteLine("------------");
            }


            Console.Read();
        }
    }
}
