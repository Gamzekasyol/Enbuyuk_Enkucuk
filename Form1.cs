using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBüyük_EnKüçük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enbuyuk, enkucuk;
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            sayi3 = Convert.ToInt32(txtsayi3.Text);
          

            // EN BÜYÜK SAYI
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                enbuyuk = sayi1;
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                enbuyuk = sayi2;
            }
            else
                enbuyuk = sayi3;
            // EN KÜÇÜK SAYI 
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                enkucuk = sayi1;
            }
            else if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                enkucuk = sayi2;
            }
            else
                enkucuk = sayi3;

            txtkucuk.Text = enkucuk.ToString();
            txtbuyuk.Text = enbuyuk.ToString();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtsayi1.Text = "";
            txtsayi2.Text = "";
            txtsayi3.Text = "";
            txtkucuk.Text = "";
            txtbuyuk.Text = "";
        }
    }
}
