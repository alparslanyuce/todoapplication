namespace ListGenericToDoUygulama
{
    partial class yeniKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDerece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKisaAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbdurum = new System.Windows.Forms.ComboBox();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbaslik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onem Derecesi";
            // 
            // txtDerece
            // 
            this.txtDerece.Location = new System.Drawing.Point(99, 214);
            this.txtDerece.Name = "txtDerece";
            this.txtDerece.Size = new System.Drawing.Size(178, 20);
            this.txtDerece.TabIndex = 3;
            this.txtDerece.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtDerece.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txtKisaAciklama
            // 
            this.txtKisaAciklama.Location = new System.Drawing.Point(99, 39);
            this.txtKisaAciklama.Multiline = true;
            this.txtKisaAciklama.Name = "txtKisaAciklama";
            this.txtKisaAciklama.Size = new System.Drawing.Size(178, 64);
            this.txtKisaAciklama.TabIndex = 1;
            this.txtKisaAciklama.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtKisaAciklama.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(99, 109);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(178, 89);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtAciklama.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Durum";
            // 
            // cmbdurum
            // 
            this.cmbdurum.FormattingEnabled = true;
            this.cmbdurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal edildi",
            "Ertelendi"});
            this.cmbdurum.Location = new System.Drawing.Point(99, 241);
            this.cmbdurum.Name = "cmbdurum";
            this.cmbdurum.Size = new System.Drawing.Size(178, 21);
            this.cmbdurum.TabIndex = 4;
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Location = new System.Drawing.Point(99, 269);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(178, 23);
            this.btnyenikayit.TabIndex = 5;
            this.btnyenikayit.Text = "Yeni Kayıt";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Başlık";
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(99, 13);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(178, 20);
            this.txtbaslik.TabIndex = 0;
            this.txtbaslik.Enter += new System.EventHandler(this.txtbaslik_Enter);
            this.txtbaslik.Leave += new System.EventHandler(this.txtbaslik_Leave);
            // 
            // yeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 301);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.cmbdurum);
            this.Controls.Add(this.txtKisaAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbaslik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDerece);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "yeniKayit";
            this.Text = "todo- yenikayıt";
            this.Load += new System.EventHandler(this.yeniKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDerece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKisaAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbdurum;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbaslik;
    }
}