using ListGenericToDoUygulama.businessService;
using ListGenericToDoUygulama.entities;
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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void yeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void txtbaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtbaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            todoService Service = new todoService();
            int sonuc =  Service.kayitYeni(new entities.todo()
            {
                id= Guid.NewGuid(),
                baslik = txtbaslik.Text,
                kisaAciklama = txtKisaAciklama.Text,
                aciklama = txtAciklama.Text,
                durumAciklama = cmbdurum.SelectedItem.ToString(),
                onemDerece = int.Parse(txtDerece.Text),
                olusturmaTarih = DateTime.Now



            });
            if(sonuc> 0)
            {
                MessageBox.Show("kayıt ekleme işlemi başarılı", "bilgilendirme",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
               DialogResult result = MessageBox.Show("Yeni kayıt ekleme işlemine devam etmek ister misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    foreach(Control item in this.Controls)
                    {
                        if(item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitListe = Application.OpenForms["kayitListe"];
                    if(kayitListe == null)
                    {
                        kayitListe = new kayitListe();
                        kayitListe.MdiParent = Application.OpenForms["Form1"];
                        kayitListe.StartPosition = FormStartPosition.CenterScreen;
                        kayitListe.Show();
                        this.Close();
                    }

                    else
                    {
                     GroupBox Liste = (GroupBox)kayitListe.Controls["grpboxliste"];
                      DataGridView grdListe = (DataGridView)Liste.Controls["grdListe"];
                        List<todo> GuncelListe = Service.kayitListe();
                        grdListe.DataSource = null;
                        grdListe.DataSource = GuncelListe;
                        this.Close();
                    }
                }
            }

            else
            {
                MessageBox.Show("kayıt ekleme işleminde hata", "bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
