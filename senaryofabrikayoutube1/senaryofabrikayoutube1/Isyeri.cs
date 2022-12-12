using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaryofabrikayoutube1
{
    public class Isyeri
    {
        public string IsyeriAdi { get; set; }
    
        public Adres IsyeriAdresBilgisi { get; set; }


        private List<Calisan> Calisanlar { get; set; }

        public Isyeri()
        {
            Calisanlar = new List<Calisan>();
            IsyeriAdresBilgisi = new Adres();

        }


        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
            calisan.CalisanIsyeri = this;  //işyerini çalışan üzerine atamak gerek !!!
        }

        public string CalisanListele ()
        {
            string temp = "";
            foreach (Calisan calisan in Calisanlar)

            {
                temp += "Adı:" + calisan.Isim;
                
            }
            return temp;
        }

    }
}
