﻿using ListGenericToDoUygulama.businessService;
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
    public partial class sistemGiris : Form
    {
        public sistemGiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {
                kullaniciService kullaniciService = new kullaniciService();
                kullanici kontrolKullanici = kullaniciService.kullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                if(kontrolKullanici != null)
                {
                    Form anaForm = Application.OpenForms["Form1"];
                    Panel solPanel= (Panel)anaForm.Controls["pnlIslemListesi"];
                    GroupBox gbIslemListe = (GroupBox)solPanel.Controls["grpBoxIslemListe"];
                    foreach(Control item in gbIslemListe.Controls)
                    {
                        if(item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("merhaba" + kontrolKullanici.kullaniciAdi, "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("hatalı kullanıcı adı veya şifre", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz olarak giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
