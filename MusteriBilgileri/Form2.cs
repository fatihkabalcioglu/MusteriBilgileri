using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriBilgileri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<MusteriBilgi> musteriBilgileri = new List<MusteriBilgi>();
        public void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriBilgi musteriBilgi = new MusteriBilgi();
            musteriBilgi.Ad = txtAd.Text;
            musteriBilgi.Soyad = txtSoyad.Text;
            musteriBilgi.Telefon = txtTelefon.Text;
            musteriBilgi.Yas = (int)nudYas.Value;
            musteriBilgi.Adres = txtAdres.Text;

            musteriBilgileri.Add(musteriBilgi);

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            nudYas.Value = 0;
            txtAdres.Clear();
        }

        public void btnListeyeDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(musteriBilgileri);
            form1.Show();
            this.Hide();
        }
    }
}