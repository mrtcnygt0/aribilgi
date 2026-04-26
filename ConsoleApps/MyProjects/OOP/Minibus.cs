using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Minibüs sınıfı, Tasit sınıfından kalıtım alır
    internal class Minibus : Tasit
    {
        // Minibüs sınıfına özgü özellikler ve metotlar
        public int yolcuSayisi;
        public string hatKodu;
    }
}
