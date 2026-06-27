using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Uçak sınıfı, Tasit sınıfından kalıtım alır
    internal class Ucak : Tasit
    {
        // Uçak sınıfına özgü özellikler ve metotlar
        // public int yolcuSayisi;
        public double kanatGenisligi;

        private int yolcuSayisi;

        //Property kullanarak yolcuSayisi özelliği tanımlanır. Bu sayede yolcuSayisi değerine erişim ve atama işlemleri kontrol altına alınır.
        public int _yolcuSayisi
        {
            get 
            { 
                return yolcuSayisi;
            }
            set 
            { 
                if(value < 0)
                {
                    yolcuSayisi = value*(-1);
                } else if(value > 500)
                {
                    yolcuSayisi = 500;
                }
                else
                {
                    yolcuSayisi = value;
                }
            }
        }


        // Uçak sınıfına özgü metotlar
        public void Kirala()
        {
            Console.WriteLine("Uçak Kiralandı");
        }

        // Ata sınıftan devralınan Sat() metodunu, Ucak sınıfında kendine özel olarak değiştirerek kullanabilmesi durumudur.
        public new void Sat()
        {
            Console.WriteLine("Uçak Satıldı");
        }

        // override metodu, ata sınıfta virtual olarak tanımlanan bir metodu, alt sınıfta kendine özgü bir şekilde yeniden tanımlayarak kullanabilmesi durumudur.
        /*
        public override void Sat()
        {
            Console.WriteLine("Uçak Satıldı");
        }
        */

    }
}
