
namespace WindowsFormsDemo
{
    partial class GeometrikIslemler
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
            this.ddlKenarSecimi = new System.Windows.Forms.ComboBox();
            this.lKenarSecimi = new System.Windows.Forms.Label();
            this.ddlAlanCevreSecimi = new System.Windows.Forms.ComboBox();
            this.lAlanCevreSecimi = new System.Windows.Forms.Label();
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.lGiris = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.bHesapla = new System.Windows.Forms.Button();
            this.lGeometrikSekiller = new System.Windows.Forms.Label();
            this.ddlGeometrikSekil = new System.Windows.Forms.ComboBox();
            this.lSonuc = new System.Windows.Forms.Label();
            this.lSayiki = new System.Windows.Forms.Label();
            this.tbSayiki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ddlKenarSecimi
            // 
            this.ddlKenarSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKenarSecimi.FormattingEnabled = true;
            this.ddlKenarSecimi.Location = new System.Drawing.Point(318, 177);
            this.ddlKenarSecimi.Name = "ddlKenarSecimi";
            this.ddlKenarSecimi.Size = new System.Drawing.Size(167, 21);
            this.ddlKenarSecimi.TabIndex = 0;
            // 
            // lKenarSecimi
            // 
            this.lKenarSecimi.AutoSize = true;
            this.lKenarSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKenarSecimi.Location = new System.Drawing.Point(12, 177);
            this.lKenarSecimi.Name = "lKenarSecimi";
            this.lKenarSecimi.Size = new System.Drawing.Size(145, 24);
            this.lKenarSecimi.TabIndex = 1;
            this.lKenarSecimi.Text = "Kenar Seçiniz:";
            // 
            // ddlAlanCevreSecimi
            // 
            this.ddlAlanCevreSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAlanCevreSecimi.FormattingEnabled = true;
            this.ddlAlanCevreSecimi.Location = new System.Drawing.Point(318, 236);
            this.ddlAlanCevreSecimi.Name = "ddlAlanCevreSecimi";
            this.ddlAlanCevreSecimi.Size = new System.Drawing.Size(167, 21);
            this.ddlAlanCevreSecimi.TabIndex = 2;
            // 
            // lAlanCevreSecimi
            // 
            this.lAlanCevreSecimi.AutoSize = true;
            this.lAlanCevreSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lAlanCevreSecimi.Location = new System.Drawing.Point(7, 233);
            this.lAlanCevreSecimi.Name = "lAlanCevreSecimi";
            this.lAlanCevreSecimi.Size = new System.Drawing.Size(305, 24);
            this.lAlanCevreSecimi.TabIndex = 3;
            this.lAlanCevreSecimi.Text = "Çevre veya Alan seçimi yapınız:";
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(318, 12);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(167, 20);
            this.tbSayi.TabIndex = 4;
            // 
            // lGiris
            // 
            this.lGiris.AutoSize = true;
            this.lGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGiris.Location = new System.Drawing.Point(12, 12);
            this.lGiris.Name = "lGiris";
            this.lGiris.Size = new System.Drawing.Size(120, 24);
            this.lGiris.TabIndex = 5;
            this.lGiris.Text = "Sayı Giriniz:";
            // 
            // lbSonuc
            // 
            this.lbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 20;
            this.lbSonuc.Location = new System.Drawing.Point(558, 64);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(180, 184);
            this.lbSonuc.TabIndex = 6;
            // 
            // bHesapla
            // 
            this.bHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesapla.Location = new System.Drawing.Point(318, 276);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(151, 38);
            this.bHesapla.TabIndex = 7;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // lGeometrikSekiller
            // 
            this.lGeometrikSekiller.AutoSize = true;
            this.lGeometrikSekiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGeometrikSekiller.Location = new System.Drawing.Point(12, 119);
            this.lGeometrikSekiller.Name = "lGeometrikSekiller";
            this.lGeometrikSekiller.Size = new System.Drawing.Size(236, 24);
            this.lGeometrikSekiller.TabIndex = 8;
            this.lGeometrikSekiller.Text = "Geometrik Şekil Seçiniz:";
            // 
            // ddlGeometrikSekil
            // 
            this.ddlGeometrikSekil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGeometrikSekil.FormattingEnabled = true;
            this.ddlGeometrikSekil.Location = new System.Drawing.Point(318, 119);
            this.ddlGeometrikSekil.Name = "ddlGeometrikSekil";
            this.ddlGeometrikSekil.Size = new System.Drawing.Size(167, 21);
            this.ddlGeometrikSekil.TabIndex = 9;
            this.ddlGeometrikSekil.SelectedIndexChanged += new System.EventHandler(this.ddlGeometrikSekil_SelectedIndexChanged);
            // 
            // lSonuc
            // 
            this.lSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonuc.Location = new System.Drawing.Point(558, 28);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(180, 33);
            this.lSonuc.TabIndex = 10;
            this.lSonuc.Text = "Sonucunuz:";
            // 
            // lSayiki
            // 
            this.lSayiki.AutoSize = true;
            this.lSayiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSayiki.Location = new System.Drawing.Point(12, 64);
            this.lSayiki.Name = "lSayiki";
            this.lSayiki.Size = new System.Drawing.Size(241, 24);
            this.lSayiki.TabIndex = 12;
            this.lSayiki.Text = "Kısa Kenar Sayisi Giriniz:";
            // 
            // tbSayiki
            // 
            this.tbSayiki.Location = new System.Drawing.Point(318, 64);
            this.tbSayiki.Name = "tbSayiki";
            this.tbSayiki.Size = new System.Drawing.Size(167, 20);
            this.tbSayiki.TabIndex = 11;
            // 
            // GeometrikIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 510);
            this.Controls.Add(this.lSayiki);
            this.Controls.Add(this.tbSayiki);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.ddlGeometrikSekil);
            this.Controls.Add(this.lGeometrikSekiller);
            this.Controls.Add(this.bHesapla);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lGiris);
            this.Controls.Add(this.tbSayi);
            this.Controls.Add(this.lAlanCevreSecimi);
            this.Controls.Add(this.ddlAlanCevreSecimi);
            this.Controls.Add(this.lKenarSecimi);
            this.Controls.Add(this.ddlKenarSecimi);
            this.Name = "GeometrikIslemler";
            this.Text = "GeometrikIslemler";
            this.Load += new System.EventHandler(this.GeometrikIslemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlKenarSecimi;
        private System.Windows.Forms.Label lKenarSecimi;
        private System.Windows.Forms.ComboBox ddlAlanCevreSecimi;
        private System.Windows.Forms.Label lAlanCevreSecimi;
        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.Label lGiris;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button bHesapla;
        private System.Windows.Forms.Label lGeometrikSekiller;
        private System.Windows.Forms.ComboBox ddlGeometrikSekil;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Label lSayiki;
        private System.Windows.Forms.TextBox tbSayiki;
    }
}