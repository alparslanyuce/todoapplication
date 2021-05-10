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
    public partial class kayitListe : Form
    {
        todoService todoservice;
        public kayitListe()
        {
            InitializeComponent();
            todoservice = new todoService();
        }

        private void kayitListe_Load(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }


        private List<todo> TumListe()
        {
           return todoservice.kayitListe();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btntamamlandi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x=> x.durumAciklama == "Tamamlandı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btntamamlanamadi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlanamadı").ToList();
            grdListe.Columns["ID"].Visible = false;
        }

        private void btniptaledildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = TumListe().Where(x => x.durumAciklama == "İptal edildi").ToList();
            grdListe.Columns["ID"].Visible = false;
        }


    }
}
