
namespace WindowsFormsDemo
{
    partial class AdamAsmaca
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
            this.lRasgele = new System.Windows.Forms.Label();
            this.lGiris = new System.Windows.Forms.Label();
            this.tbGiris = new System.Windows.Forms.TextBox();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.bGöster = new System.Windows.Forms.Button();
            this.lDebugGelenKelime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lRasgele
            // 
            this.lRasgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lRasgele.Location = new System.Drawing.Point(177, 21);
            this.lRasgele.Name = "lRasgele";
            this.lRasgele.Size = new System.Drawing.Size(169, 38);
            this.lRasgele.TabIndex = 0;
            this.lRasgele.Text = "lRasgeleKelime:";
            // 
            // lGiris
            // 
            this.lGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGiris.Location = new System.Drawing.Point(12, 93);
            this.lGiris.Name = "lGiris";
            this.lGiris.Size = new System.Drawing.Size(159, 34);
            this.lGiris.TabIndex = 1;
            this.lGiris.Text = "Harf Giriniz:";
            // 
            // tbGiris
            // 
            this.tbGiris.Location = new System.Drawing.Point(145, 93);
            this.tbGiris.Name = "tbGiris";
            this.tbGiris.Size = new System.Drawing.Size(245, 20);
            this.tbGiris.TabIndex = 2;
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(427, 33);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(146, 173);
            this.lbSonuc.TabIndex = 11;
            // 
            // bGöster
            // 
            this.bGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGöster.Location = new System.Drawing.Point(226, 133);
            this.bGöster.Name = "bGöster";
            this.bGöster.Size = new System.Drawing.Size(75, 23);
            this.bGöster.TabIndex = 12;
            this.bGöster.Text = "Tahmin Et";
            this.bGöster.UseVisualStyleBackColor = true;
            this.bGöster.Click += new System.EventHandler(this.bGöster_Click);
            // 
            // lDebugGelenKelime
            // 
            this.lDebugGelenKelime.AutoSize = true;
            this.lDebugGelenKelime.Location = new System.Drawing.Point(163, 219);
            this.lDebugGelenKelime.Name = "lDebugGelenKelime";
            this.lDebugGelenKelime.Size = new System.Drawing.Size(38, 13);
            this.lDebugGelenKelime.TabIndex = 13;
            this.lDebugGelenKelime.Text = "Sonuc";
            // 
            // AdamAsmaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lDebugGelenKelime);
            this.Controls.Add(this.bGöster);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.tbGiris);
            this.Controls.Add(this.lGiris);
            this.Controls.Add(this.lRasgele);
            this.Name = "AdamAsmaca";
            this.Text = "AdamAsmaca";
            this.Load += new System.EventHandler(this.AdamAsmaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRasgele;
        private System.Windows.Forms.Label lGiris;
        private System.Windows.Forms.TextBox tbGiris;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button bGöster;
        private System.Windows.Forms.Label lDebugGelenKelime;
    }
}