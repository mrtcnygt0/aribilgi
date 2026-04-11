using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenCalisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            // -------------------------------------------------------------------------------------------------------------------- //
            // Değişkenlere sayı girilecek, 2 sayı alınacak birbiriyle çarpılacak. Ürün fiyatı, ürün adedi çarpılıp tutar hesaplanacak.
            // -------------------------------------------------------------------------------------------------------------------- //

            double urunFiyat;
            int urunAdet;
            double urunTutar;


            Basla:

            Console.WriteLine("----------   ÜRÜN BİLGİLERİ   ----------------");
            urunFiyat = 0;
            urunAdet = 0;
            urunTutar = 0;

            do
            {
            Fiyat:
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(">Ürün fiyatını giriniz: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    urunFiyat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (urunFiyat < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Ürün fiyatı 0 veya 0' dan büyük olmalı. Lütfen tekrar deneyin...");
                        Console.WriteLine();
                        goto Adet;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Geçersiz fiyat değeri girildi, lütfen tekrar deneyin...");
                    Console.WriteLine();
                    goto Fiyat;
                }

            Adet:
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(">Ürün adedi giriniz: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    urunAdet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (urunAdet < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Ürün adedi 0 veya 0' dan büyük olmalı. Lütfen tekrar deneyin...");
                        Console.WriteLine();
                        goto Adet;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Geçersiz adet değeri girildi, lütfen tekrar deneyin...");
                    Console.WriteLine();
                    goto Adet;
                }

                urunTutar = urunAdet * urunFiyat;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ürün Tutar: " + urunTutar + " TL");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------");

                Console.WriteLine();
                Console.WriteLine("Yeniden denemek ister misiniz? Evet=E , Hayır=H");

                DevamMi:
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    char secim = Convert.ToChar(Console.ReadLine());
                    if (secim == 'E' || secim == 'e') 
                    { 
                        Console.Clear();
                        goto Basla; 
                    }
                    
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("Geçersiz seçim yaptınız, lütfen tekrar deneyin...");
                    Console.WriteLine();
                    goto DevamMi;
                }
                

            } while (true);
            {

            }
            */


            /* 
             
            // -------------------------------------------------------------------------------------------------------------------- //
            // Ortalama notu hesaplanması - ORT = Vize * 0.4 + Final * 0.6  || Not 50 den küçükse kaldınız, büyükse geçtiniz yazsın.//
            // -------------------------------------------------------------------------------------------------------------------- //

            double vizeNotu;
            double finalNotu;
            double ortalama;

            Console.WriteLine("----------   NOT HESAPLAMA   ----------------");

            

            Vize:
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Vize notunuzu giriniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                vizeNotu = Convert.ToDouble(Console.ReadLine());
                if (vizeNotu > 100 || vizeNotu < 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geçersiz not aralığı girdiniz. Lütfen tekrar deneyiniz...");
                    goto Vize;
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz Vize değeri girdiniz. Lütfen tekrar deneyiniz...");
                goto Vize;
            }

            Console.WriteLine();


            

            Final:
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Final notunuzu giriniz: ");
                Console.ForegroundColor = ConsoleColor.White;
                finalNotu = Convert.ToDouble(Console.ReadLine());
                if (finalNotu > 100 || finalNotu < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geçersiz not aralığı girdiniz. Lütfen tekrar deneyiniz...");
                    goto Final;
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz Final değeri girdiniz. Lütfen tekrar deneyiniz...");
                goto Final;
            }

            Console.WriteLine();

            ortalama = vizeNotu * 0.40 + finalNotu * 0.60;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Notunuz:" + ortalama);
            if(ortalama < 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Başarısız! Kaldınız.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Başarılı! Geçtiniz.");
            }

            Console.Read();

            */


            // -------------------------------------------------------------------------------------------------------------------- //
            // Ekrandan:
            // 1) Kullanıcı adı girilecek,
            // 2) Şifre girilecek,
            // 3) Kullanıcı adı ve şifre doğruysa "Hoş Geldiniz!" yazacak. Değil ise "girilen bilgiler hatalı, yeniden deneyin" yazacak
            // user = abc
            // pass = 1234
            // -------------------------------------------------------------------------------------------------------------------- //
            Console.Title = "XYZ BANKASI";

            string user = "abc";
            string pass = "1234";
            int deneme = 3;

            string username;
            string password;

            Console.WriteLine("----------   XYZ BANKASINA HOŞ GELDİNİZ   ----------------");

            Main:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*** LOGIN ***");

            try
            {

                if (deneme < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Giriş hakkınız tükendi!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Kullanıcı Adı: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    username = Console.ReadLine().ToLower();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Şifre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    password = Console.ReadLine().ToLower();

                    if (username == user && password == pass)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Hoş Geldiniz! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(username);
                    }
                    else
                    {
                        deneme--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Giriş Bilgileri Hatalı!" + " Kalan Hakkınız: " + deneme);
                        goto Main;
                    }
                }
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış değer girdiniz. Lütfen tekrar deneyiniz...");
                goto Main;
            }

            Console.ReadKey();

        }
    }
}
