namespace ListGenericToDoUygulama
{
    partial class kayitListe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btniptaledildi = new System.Windows.Forms.Button();
            this.btntamamlanamadi = new System.Windows.Forms.Button();
            this.btntamamlandi = new System.Windows.Forms.Button();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.grpboxliste = new System.Windows.Forms.GroupBox();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grpboxliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btniptaledildi);
            this.groupBox1.Controls.Add(this.btntamamlanamadi);
            this.groupBox1.Controls.Add(this.btntamamlandi);
            this.groupBox1.Controls.Add(this.btnTumListe);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // btniptaledildi
            // 
            this.btniptaledildi.Location = new System.Drawing.Point(7, 142);
            this.btniptaledildi.Name = "btniptaledildi";
            this.btniptaledildi.Size = new System.Drawing.Size(187, 23);
            this.btniptaledildi.TabIndex = 0;
            this.btniptaledildi.Text = "İptal Edildi";
            this.btniptaledildi.UseVisualStyleBackColor = true;
            this.btniptaledildi.Click += new System.EventHandler(this.btniptaledildi_Click);
            // 
            // btntamamlanamadi
            // 
            this.btntamamlanamadi.Location = new System.Drawing.Point(7, 113);
            this.btntamamlanamadi.Name = "btntamamlanamadi";
            this.btntamamlanamadi.Size = new System.Drawing.Size(187, 23);
            this.btntamamlanamadi.TabIndex = 0;
            this.btntamamlanamadi.Text = "Tamamlanamadı";
            this.btntamamlanamadi.UseVisualStyleBackColor = true;
            this.btntamamlanamadi.Click += new System.EventHandler(this.btntamamlanamadi_Click);
            // 
            // btntamamlandi
            // 
            this.btntamamlandi.Location = new System.Drawing.Point(6, 84);
            this.btntamamlandi.Name = "btntamamlandi";
            this.btntamamlandi.Size = new System.Drawing.Size(187, 23);
            this.btntamamlandi.TabIndex = 0;
            this.btntamamlandi.Text = "Tamamlandı";
            this.btntamamlandi.UseVisualStyleBackColor = true;
            this.btntamamlandi.Click += new System.EventHandler(this.btntamamlandi_Click);
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(7, 55);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(187, 23);
            this.btnTumListe.TabIndex = 0;
            this.btnTumListe.Text = "Tüm Liste";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // grpboxliste
            // 
            this.grpboxliste.Controls.Add(this.grdListe);
            this.grpboxliste.Location = new System.Drawing.Point(230, 13);
            this.grpboxliste.Name = "grpboxliste";
            this.grpboxliste.Size = new System.Drawing.Size(627, 425);
            this.grpboxliste.TabIndex = 1;
            this.grpboxliste.TabStop = false;
            this.grpboxliste.Text = "Liste";
            // 
            // grdListe
            // 
            this.grdListe.AllowUserToAddRows = false;
            this.grdListe.AllowUserToDeleteRows = false;
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(3, 16);
            this.grdListe.Name = "grdListe";
            this.grdListe.ReadOnly = true;
            this.grdListe.Size = new System.Drawing.Size(621, 406);
            this.grdListe.TabIndex = 0;
            // 
            // kayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.grpboxliste);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "todo- kayıt liste";
            this.Load += new System.EventHandler(this.kayitListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpboxliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpboxliste;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Button btniptaledildi;
        private System.Windows.Forms.Button btntamamlanamadi;
        private System.Windows.Forms.Button btntamamlandi;
        private System.Windows.Forms.Button btnTumListe;
    }
}