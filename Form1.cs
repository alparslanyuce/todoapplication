using ListGenericToDoUygulama.businessService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListGenericToDoUygulama
{
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void ButonAcKapa(bool kontrol)
        {

            foreach (Control item in grpBoxIslemListe.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = false;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm_zamanla.Interval = 15000;
            tm_zamanla.Tick += tm_zamanla_Tick;
            tm_zamanla.Start();


            ButonAcKapa(false);

            sistemGiris kullaniciKontrol = new sistemGiris();
            kullaniciKontrol.MdiParent = this;
            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;
            kullaniciKontrol.Show();
        }

        private void tm_zamanla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");

        }

        private void btnUygulamaKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["yeniKayit"] != null)
            {
                T = Application.OpenForms["yeniKayit"];
                T.Focus();
            }
            else
            {
                T = new yeniKayit();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btnKayitListe_Click(object sender, EventArgs e)
        {
            todoService todoservis = new todoService();
            if(todoservis.kayitKontrol() > 0)
            {
                kayitListe kayitListe = new kayitListe();
                kayitListe.MdiParent = this;
                kayitListe.Show();
            }

            else
            {
                MessageBox.Show("Listelenecek kayıt bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
