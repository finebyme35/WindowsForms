
namespace WindowsFormsDemo
{
    partial class Calculator
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
            this.bToplama = new System.Windows.Forms.Button();
            this.bCikarma = new System.Windows.Forms.Button();
            this.bKokAlma = new System.Windows.Forms.Button();
            this.bUsAlma = new System.Windows.Forms.Button();
            this.bBolme = new System.Windows.Forms.Button();
            this.bCarpma = new System.Windows.Forms.Button();
            this.bEsittir = new System.Windows.Forms.Button();
            this.bCokluSilme = new System.Windows.Forms.Button();
            this.tbGiris = new System.Windows.Forms.TextBox();
            this.bMod = new System.Windows.Forms.Button();
            this.bVirgul = new System.Windows.Forms.Button();
            this.bSekiz = new System.Windows.Forms.Button();
            this.bYedi = new System.Windows.Forms.Button();
            this.bAlti = new System.Windows.Forms.Button();
            this.bBes = new System.Windows.Forms.Button();
            this.bDort = new System.Windows.Forms.Button();
            this.bUc = new System.Windows.Forms.Button();
            this.bİki = new System.Windows.Forms.Button();
            this.bBir = new System.Windows.Forms.Button();
            this.bDokuz = new System.Windows.Forms.Button();
            this.bSifir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bToplama
            // 
            this.bToplama.BackColor = System.Drawing.Color.White;
            this.bToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bToplama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bToplama.Location = new System.Drawing.Point(300, 248);
            this.bToplama.Name = "bToplama";
            this.bToplama.Size = new System.Drawing.Size(75, 37);
            this.bToplama.TabIndex = 0;
            this.bToplama.Text = "+";
            this.bToplama.UseVisualStyleBackColor = false;
            this.bToplama.Click += new System.EventHandler(this.bToplama_Click);
            // 
            // bCikarma
            // 
            this.bCikarma.BackColor = System.Drawing.Color.White;
            this.bCikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCikarma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bCikarma.Location = new System.Drawing.Point(300, 208);
            this.bCikarma.Name = "bCikarma";
            this.bCikarma.Size = new System.Drawing.Size(75, 37);
            this.bCikarma.TabIndex = 1;
            this.bCikarma.Text = "-";
            this.bCikarma.UseVisualStyleBackColor = false;
            this.bCikarma.Click += new System.EventHandler(this.bCikarma_Click);
            // 
            // bKokAlma
            // 
            this.bKokAlma.BackColor = System.Drawing.Color.White;
            this.bKokAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKokAlma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bKokAlma.Location = new System.Drawing.Point(220, 165);
            this.bKokAlma.Name = "bKokAlma";
            this.bKokAlma.Size = new System.Drawing.Size(75, 37);
            this.bKokAlma.TabIndex = 3;
            this.bKokAlma.Text = "√x";
            this.bKokAlma.UseVisualStyleBackColor = false;
            this.bKokAlma.Click += new System.EventHandler(this.bKokAlma_Click);
            // 
            // bUsAlma
            // 
            this.bUsAlma.BackColor = System.Drawing.Color.White;
            this.bUsAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUsAlma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bUsAlma.Location = new System.Drawing.Point(139, 122);
            this.bUsAlma.Name = "bUsAlma";
            this.bUsAlma.Size = new System.Drawing.Size(75, 37);
            this.bUsAlma.TabIndex = 4;
            this.bUsAlma.Text = "x²";
            this.bUsAlma.UseVisualStyleBackColor = false;
            this.bUsAlma.Click += new System.EventHandler(this.bUsAlma_Click);
            // 
            // bBolme
            // 
            this.bBolme.BackColor = System.Drawing.Color.White;
            this.bBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBolme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bBolme.Location = new System.Drawing.Point(299, 122);
            this.bBolme.Name = "bBolme";
            this.bBolme.Size = new System.Drawing.Size(75, 37);
            this.bBolme.TabIndex = 5;
            this.bBolme.Text = "÷";
            this.bBolme.UseVisualStyleBackColor = false;
            this.bBolme.Click += new System.EventHandler(this.bBolme_Click);
            // 
            // bCarpma
            // 
            this.bCarpma.BackColor = System.Drawing.Color.White;
            this.bCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCarpma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bCarpma.Location = new System.Drawing.Point(299, 165);
            this.bCarpma.Name = "bCarpma";
            this.bCarpma.Size = new System.Drawing.Size(75, 37);
            this.bCarpma.TabIndex = 6;
            this.bCarpma.Text = "x";
            this.bCarpma.UseVisualStyleBackColor = false;
            this.bCarpma.Click += new System.EventHandler(this.bCarpma_Click);
            // 
            // bEsittir
            // 
            this.bEsittir.BackColor = System.Drawing.Color.White;
            this.bEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEsittir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bEsittir.Location = new System.Drawing.Point(300, 294);
            this.bEsittir.Name = "bEsittir";
            this.bEsittir.Size = new System.Drawing.Size(74, 37);
            this.bEsittir.TabIndex = 7;
            this.bEsittir.Text = "=";
            this.bEsittir.UseVisualStyleBackColor = false;
            this.bEsittir.Click += new System.EventHandler(this.bEsittir_Click);
            // 
            // bCokluSilme
            // 
            this.bCokluSilme.BackColor = System.Drawing.Color.White;
            this.bCokluSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCokluSilme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bCokluSilme.Location = new System.Drawing.Point(219, 122);
            this.bCokluSilme.Name = "bCokluSilme";
            this.bCokluSilme.Size = new System.Drawing.Size(75, 37);
            this.bCokluSilme.TabIndex = 8;
            this.bCokluSilme.Text = "C";
            this.bCokluSilme.UseVisualStyleBackColor = false;
            this.bCokluSilme.Click += new System.EventHandler(this.bCokluSilme_Click);
            // 
            // tbGiris
            // 
            this.tbGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGiris.Location = new System.Drawing.Point(57, 41);
            this.tbGiris.Multiline = true;
            this.tbGiris.Name = "tbGiris";
            this.tbGiris.ReadOnly = true;
            this.tbGiris.Size = new System.Drawing.Size(318, 75);
            this.tbGiris.TabIndex = 9;
            this.tbGiris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bMod
            // 
            this.bMod.BackColor = System.Drawing.Color.White;
            this.bMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bMod.Location = new System.Drawing.Point(57, 122);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(75, 37);
            this.bMod.TabIndex = 12;
            this.bMod.Text = "%";
            this.bMod.UseVisualStyleBackColor = false;
            this.bMod.Click += new System.EventHandler(this.bMod_Click);
            // 
            // bVirgul
            // 
            this.bVirgul.BackColor = System.Drawing.Color.White;
            this.bVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bVirgul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bVirgul.Location = new System.Drawing.Point(57, 165);
            this.bVirgul.Name = "bVirgul";
            this.bVirgul.Size = new System.Drawing.Size(75, 37);
            this.bVirgul.TabIndex = 13;
            this.bVirgul.Text = ",";
            this.bVirgul.UseVisualStyleBackColor = false;
            this.bVirgul.Click += new System.EventHandler(this.bVirgul_Click);
            // 
            // bSekiz
            // 
            this.bSekiz.BackColor = System.Drawing.Color.White;
            this.bSekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSekiz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSekiz.Location = new System.Drawing.Point(139, 294);
            this.bSekiz.Name = "bSekiz";
            this.bSekiz.Size = new System.Drawing.Size(75, 37);
            this.bSekiz.TabIndex = 14;
            this.bSekiz.Text = "8";
            this.bSekiz.UseVisualStyleBackColor = false;
            this.bSekiz.Click += new System.EventHandler(this.bSekiz_Click);
            // 
            // bYedi
            // 
            this.bYedi.BackColor = System.Drawing.Color.White;
            this.bYedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYedi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bYedi.Location = new System.Drawing.Point(58, 294);
            this.bYedi.Name = "bYedi";
            this.bYedi.Size = new System.Drawing.Size(75, 37);
            this.bYedi.TabIndex = 15;
            this.bYedi.Text = "7";
            this.bYedi.UseVisualStyleBackColor = false;
            this.bYedi.Click += new System.EventHandler(this.bYedi_Click);
            // 
            // bAlti
            // 
            this.bAlti.BackColor = System.Drawing.Color.White;
            this.bAlti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAlti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bAlti.Location = new System.Drawing.Point(219, 248);
            this.bAlti.Name = "bAlti";
            this.bAlti.Size = new System.Drawing.Size(75, 37);
            this.bAlti.TabIndex = 16;
            this.bAlti.Text = "6";
            this.bAlti.UseVisualStyleBackColor = false;
            this.bAlti.Click += new System.EventHandler(this.bAlti_Click);
            // 
            // bBes
            // 
            this.bBes.BackColor = System.Drawing.Color.White;
            this.bBes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bBes.Location = new System.Drawing.Point(139, 248);
            this.bBes.Name = "bBes";
            this.bBes.Size = new System.Drawing.Size(75, 37);
            this.bBes.TabIndex = 17;
            this.bBes.Text = "5";
            this.bBes.UseVisualStyleBackColor = false;
            this.bBes.Click += new System.EventHandler(this.bBes_Click);
            // 
            // bDort
            // 
            this.bDort.BackColor = System.Drawing.Color.White;
            this.bDort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bDort.Location = new System.Drawing.Point(57, 248);
            this.bDort.Name = "bDort";
            this.bDort.Size = new System.Drawing.Size(75, 37);
            this.bDort.TabIndex = 18;
            this.bDort.Text = "4";
            this.bDort.UseVisualStyleBackColor = false;
            this.bDort.Click += new System.EventHandler(this.bDort_Click);
            // 
            // bUc
            // 
            this.bUc.BackColor = System.Drawing.Color.White;
            this.bUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bUc.Location = new System.Drawing.Point(220, 208);
            this.bUc.Name = "bUc";
            this.bUc.Size = new System.Drawing.Size(75, 37);
            this.bUc.TabIndex = 19;
            this.bUc.Text = "3";
            this.bUc.UseVisualStyleBackColor = false;
            this.bUc.Click += new System.EventHandler(this.bUc_Click);
            // 
            // bİki
            // 
            this.bİki.BackColor = System.Drawing.Color.White;
            this.bİki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bİki.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bİki.Location = new System.Drawing.Point(139, 208);
            this.bİki.Name = "bİki";
            this.bİki.Size = new System.Drawing.Size(75, 37);
            this.bİki.TabIndex = 20;
            this.bİki.Text = "2";
            this.bİki.UseVisualStyleBackColor = false;
            this.bİki.Click += new System.EventHandler(this.bİki_Click);
            // 
            // bBir
            // 
            this.bBir.BackColor = System.Drawing.Color.White;
            this.bBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bBir.Location = new System.Drawing.Point(58, 208);
            this.bBir.Name = "bBir";
            this.bBir.Size = new System.Drawing.Size(75, 37);
            this.bBir.TabIndex = 21;
            this.bBir.Text = "1";
            this.bBir.UseVisualStyleBackColor = false;
            this.bBir.Click += new System.EventHandler(this.bBir_Click);
            // 
            // bDokuz
            // 
            this.bDokuz.BackColor = System.Drawing.Color.White;
            this.bDokuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDokuz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bDokuz.Location = new System.Drawing.Point(220, 294);
            this.bDokuz.Name = "bDokuz";
            this.bDokuz.Size = new System.Drawing.Size(75, 37);
            this.bDokuz.TabIndex = 22;
            this.bDokuz.Text = "9";
            this.bDokuz.UseVisualStyleBackColor = false;
            this.bDokuz.Click += new System.EventHandler(this.bDokuz_Click);
            // 
            // bSifir
            // 
            this.bSifir.BackColor = System.Drawing.Color.White;
            this.bSifir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSifir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSifir.Location = new System.Drawing.Point(140, 165);
            this.bSifir.Name = "bSifir";
            this.bSifir.Size = new System.Drawing.Size(74, 37);
            this.bSifir.TabIndex = 23;
            this.bSifir.Text = "0";
            this.bSifir.UseVisualStyleBackColor = false;
            this.bSifir.Click += new System.EventHandler(this.bSifir_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSifir);
            this.Controls.Add(this.bDokuz);
            this.Controls.Add(this.bBir);
            this.Controls.Add(this.bİki);
            this.Controls.Add(this.bUc);
            this.Controls.Add(this.bDort);
            this.Controls.Add(this.bBes);
            this.Controls.Add(this.bAlti);
            this.Controls.Add(this.bYedi);
            this.Controls.Add(this.bSekiz);
            this.Controls.Add(this.bVirgul);
            this.Controls.Add(this.bMod);
            this.Controls.Add(this.tbGiris);
            this.Controls.Add(this.bCokluSilme);
            this.Controls.Add(this.bEsittir);
            this.Controls.Add(this.bCarpma);
            this.Controls.Add(this.bBolme);
            this.Controls.Add(this.bUsAlma);
            this.Controls.Add(this.bKokAlma);
            this.Controls.Add(this.bCikarma);
            this.Controls.Add(this.bToplama);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bToplama;
        private System.Windows.Forms.Button bCikarma;
        private System.Windows.Forms.Button bKokAlma;
        private System.Windows.Forms.Button bUsAlma;
        private System.Windows.Forms.Button bBolme;
        private System.Windows.Forms.Button bCarpma;
        private System.Windows.Forms.Button bEsittir;
        private System.Windows.Forms.Button bCokluSilme;
        private System.Windows.Forms.TextBox tbGiris;
        private System.Windows.Forms.Button bMod;
        private System.Windows.Forms.Button bVirgul;
        private System.Windows.Forms.Button bSekiz;
        private System.Windows.Forms.Button bYedi;
        private System.Windows.Forms.Button bAlti;
        private System.Windows.Forms.Button bBes;
        private System.Windows.Forms.Button bDort;
        private System.Windows.Forms.Button bUc;
        private System.Windows.Forms.Button bİki;
        private System.Windows.Forms.Button bBir;
        private System.Windows.Forms.Button bDokuz;
        private System.Windows.Forms.Button bSifir;
    }
}