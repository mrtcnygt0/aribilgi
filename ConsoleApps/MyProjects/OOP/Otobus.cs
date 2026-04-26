using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Otobüs sınıfı, Tasit sınıfından kalıtım alır
    internal class Otobus : Tasit
    {
        // Otobüs sınıfına özgü özellikler ve metotlar
        public int yolcuSayisi;
        public string hatKodu;
    }
}
