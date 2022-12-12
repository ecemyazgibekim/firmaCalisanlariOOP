using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaryofabrikayoutube1
{
    public class Calisan :Kisi
    {
        public int SGKNo { get; set; }
        public Isyeri CalisanIsyeri { get; set; }
        public Calisan()
        {
            CalisanIsyeri= new Isyeri();    
        }
        public string Gorev { get; set; }
        public string Departman { get; set; }
    }
}
