using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senaryofabrikayoutube1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Isyeri isyeri = new Isyeri();

            isyeri.IsyeriAdi = "BlueSoft";
            isyeri.IsyeriAdresBilgisi.Il = "İzmir";

            
            Calisan calisan1 = new Calisan();

            calisan1.Isim = "Mr. X";
            calisan1.Departman = "Yazilim";
            calisan1.Gorev = "Yazilim Uzmani";
            //calisan1.CalisanIsyeri=bluesoft;
            isyeri.CalisanEkle(calisan1);

            Calisan calisan2 = new Calisan
            {
                Isim = "Mrs.Y",
                Departman = "Yazilim",
                Gorev = "Test Uzmani"
                //CalisanIsyeri=bluesoft;
            }; 
            
            isyeri.CalisanEkle(calisan2);

           MessageBox.Show(isyeri.CalisanListele()) ;

        }
    }
}
