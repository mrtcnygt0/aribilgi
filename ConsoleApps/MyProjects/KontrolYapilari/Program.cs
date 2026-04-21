using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////
            ////          KONTROL   YAPILARI             ////
            /////////////////////////////////////////////////
            
            // *****    IF - ELSE    ***** //

            /*
            int sayi = 0;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0) 
            {
                Console.WriteLine("Girdiğiniz sayı ÇİFT!");
            } 
            else
            {
                Console.WriteLine("Girdiğiniz sayı TEK!");
            }
            */

            // ******* Örnek ********* //
            /////////////////////////////
            ///  Basit Hesap Makinesi ///
            /////////////////////////////
            
            // Toplama operatörü: +
            // Çıkarma operatörü: -
            // Bölme operatörü: /
            // Çarpma operaötür: *
            // AND (Ve) operatörü: &&
            // OR (Veya) operatörü: ||

            TamHesapDongu:
            Console.Write("Sayı 1: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayı 2: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            HesapDongu:
            Console.WriteLine("1) Toplama: +");
            Console.WriteLine("2) Çıkarma: -");
            Console.WriteLine("3) Çarpma: *");
            Console.WriteLine("4) Bölme: /");
            Console.Write("İşlem seçin (+,-,*,/): ");

            string islem = Console.ReadLine();

            double sonuc = 0;

            // if - else ile kullanım
            /*
            if(islem == "1" || islem == "+")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine($"Toplama Sonucu: {sayi1} + {sayi2} = {sonuc}");

                ToplamaTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    string dongu = Console.ReadLine().ToLower();
                    if (dongu == "e")
                    {
                        Console.Clear();
                        goto TamHesapDongu;
                    }
                    else if (dongu == "h") { }
                    else
                    {
                        Console.WriteLine("Yanlış seçim yaptınız...");
                        goto ToplamaTekrar;
                    }

            } else if (islem == "2" || islem == "-")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine($"Çıkarma Sonucu: {sayi1} - {sayi2} = {sonuc}");

                CikarmaTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    string dongu2 = Console.ReadLine().ToLower();
                    if (dongu2 == "e")
                    {
                        Console.Clear();
                        goto TamHesapDongu;
                    }
                else if (dongu2.ToLower() == "h") { }
                    else
                    {
                        Console.WriteLine("Yanlış seçim yaptınız...");
                        goto CikarmaTekrar;
                    }

            } else if (islem == "3" || islem == "*")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine($"Çarpma Sonucu: {sayi1} * {sayi2} = {sonuc}");

                CarpmaTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    string dongu3 = Console.ReadLine().ToLower();
                    if (dongu3 == "e")
                    {
                        Console.Clear();
                        goto TamHesapDongu;
                    }
                else if (dongu3 == "h") { }
                    else
                    {
                        Console.WriteLine("Yanlış seçim yaptınız...");
                        goto CarpmaTekrar;
                    }

            } else if (islem == "4" || islem == "/")
            {
                if(sayi2 == 0)
                {
                    Console.WriteLine("Bölme işlemi için ikinci sayı '0' olamaz.");

                    SecimTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    string dongu4 = Console.ReadLine().ToLower();
                    if (dongu4 == "e")
                    {
                        Console.Clear();
                        goto TamHesapDongu;
                    }
                    else if (dongu4 == "h") { }
                    else
                    {
                        Console.WriteLine("Yanlış seçim yaptınız...");
                        goto SecimTekrar;
                    }
                }
                sonuc = sayi1 / sayi2;
                Console.WriteLine($"Bölme Sonucu: {sayi1} / {sayi2} = {sonuc}");

                BolmeTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    string dongu5 = Console.ReadLine();
                    if (dongu5 == "e")
                    {
                        Console.Clear();
                        goto TamHesapDongu;
                    }
                else if (dongu5 == "h") { }
                    else
                    {
                        Console.WriteLine("Yanlış seçim yaptınız...");
                        goto BolmeTekrar;
                    }

            } else
            {
                Console.Clear();
                Console.WriteLine("Yanlış seçim yaptınız. Lütfen tekrar deneyin...");
                goto HesapDongu;

            }
            */

            // switch - case ile kullanım
            string dongu;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Toplama Sonucu: {sayi1} + {sayi2} = {sonuc}");

                    ToplamaTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    dongu = Console.ReadLine().ToLower();
                    switch (dongu)
                    {
                        case "e":
                            Console.Clear();
                            goto TamHesapDongu;
                        case "h":
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim yaptınız...");
                            goto ToplamaTekrar;
                    }

                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Çıkarma Sonucu: {sayi1} - {sayi2} = {sonuc}");

                    CikarmaTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    dongu = Console.ReadLine().ToLower();
                    switch (dongu)
                    {
                        case "e":
                            Console.Clear();
                            goto TamHesapDongu;
                        case "h":
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim yaptınız...");
                            goto CikarmaTekrar;
                    }

                    break;

                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Çarpma Sonucu: {sayi1} * {sayi2} = {sonuc}");

                    CarpmaTekrar:
                    Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                    dongu = Console.ReadLine().ToLower();
                    switch (dongu)
                    {
                        case "e":
                            Console.Clear();
                            goto TamHesapDongu;
                        case "h":
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim yaptınız...");
                            goto CarpmaTekrar;
                    }

                    break;

                case "/":
                    switch (sayi2)
                    {
                        case 0:
                            Console.WriteLine("Bölme işlemi için ikinci sayı '0' olamaz.");
                            SecimTekrar:
                            Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                            string dongu4 = Console.ReadLine().ToLower();
                            switch (dongu4)
                            {
                                case "e":
                                    Console.Clear();
                                    goto TamHesapDongu;
                                case "h":
                                    break;
                                default:
                                    Console.WriteLine("Yanlış seçim yaptınız...");
                                    goto SecimTekrar;
                            }
                            
                            break;
                        default:
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine($"Bölme Sonucu: {sayi1} / {sayi2} = {sonuc}");

                            BolmeTekrar:
                            Console.Write("Yeni bir işlem yapmak istiyor musunuz? (e/h): ");
                            dongu = Console.ReadLine().ToLower();
                            switch (dongu)
                            {
                                case "e":
                                    Console.Clear();
                                    goto TamHesapDongu;
                                case "h":
                                    break;
                                default:
                                    Console.WriteLine("Yanlış seçim yaptınız...");
                                    goto BolmeTekrar;
                            }
                            break;
                    }

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Yanlış seçim yaptınız. Lütfen tekrar deneyin...");
                    goto HesapDongu;
            }
            Console.WriteLine("Güle Güle...");


            Console.ReadKey();
        }
    }
}
