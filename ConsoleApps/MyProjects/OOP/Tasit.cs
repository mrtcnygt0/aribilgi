using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bu projenin konusu taşıtlar ve taşıtların kalıtım ilişkisi içerisinde oluşturulmasıdır.
// Taşıt sınıfı, otomobil, motosiklet, otobüs, minibüs ve kamyon sınıflarının ortak özelliklerini ve davranışlarını içerir.
// Otobüs, minibüs ve kamyon sınıfları, taşıt sınıfından kalıtım alır ve kendi özgü özellikler ve metotlar ekler.
// Uçak sınıfı da taşıt sınıfından kalıtım alır ve kendi özgü özellikler ve metotlar ekler.

namespace OOP
{
    // Taşıt sınıfı, otomobil, motosiklet, Otobus, Minibus ve Kamyon sınıflarının ortak özelliklerini ve davranışlarını içerir
    internal class Tasit
    {
        public int ID;
        public string plaka;
        public string marka;
        public string model;
        public int uretimYili;
        private double fiyat;
        public bool stoktaMi;
        public DateTime stokGirisTarihi;
        // private int maksimumHiz;

        // Property kullanarak maksimumHiz özelliği tanımlanır. Bu sayede maksimumHiz değerine erişim ve atama işlemleri kontrol altına alınır.
        private int maximumHiz;
        public int _maximumHiz
        {
            get { return maximumHiz; }
            set
            {
                if (value < 0)
                    maximumHiz = value * (-1);
                else if (value > 1000000000)
                    maximumHiz = 1000000000;
                else
                    maximumHiz = value;
            }
        }

        //Manuel olarak fiyat özelliği için getter ve setter metotları tanımlanır. Bu sayede fiyat değerine erişim ve atama işlemleri kontrol altına alınır.
        public void SetFiyat(double deger)
        {
            if (deger < 0)
                fiyat = deger * (-1);
            else if (deger > 1000000000)
                fiyat = 1000000000;
            else 
                fiyat = deger;
        }

        public double GetFiyat()
        {
            return fiyat;
        }



        //Ortak metotlar
        public void Listele()
        {
            Console.WriteLine("Taşıt listelendi");
        }

        public void Al()
        {
            Console.WriteLine("Taşıt Alındı");
        }

        public void Sat()
        {
            Console.WriteLine("Taşıt Satıldı");
        }
    }
}
