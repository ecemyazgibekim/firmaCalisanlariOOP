using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaryofabrikayoutube1
{
    public class Kisi
    {
        public long TCKimlikNo { get; set; }
        public string  Isim { get; set; }
        public Adres AdresBilgisi { get; set; }

        public Kisi()
        {
               AdresBilgisi= new Adres();  
        }
    }
}
