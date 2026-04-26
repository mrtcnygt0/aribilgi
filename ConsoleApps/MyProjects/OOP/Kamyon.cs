using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Kamyon sınıfı, Tasit sınıfından kalıtım alır
    internal class Kamyon : Tasit
    {
        // Kamyon sınıfına özgü özellikler ve metotlar
        public bool damperliMi;
        public double yukKapasitesi;
    }
}
