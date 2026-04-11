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
        }
    }
}
