
namespace WindowsFormsDemo
{
    partial class SesliSessiz
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
            this.tbGiris = new System.Windows.Forms.TextBox();
            this.ddlSesliSessiz = new System.Windows.Forms.ComboBox();
            this.lGiris = new System.Windows.Forms.Label();
            this.lSeciniz = new System.Windows.Forms.Label();
            this.lbSesli = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSessiz = new System.Windows.Forms.ListBox();
            this.lSesliler = new System.Windows.Forms.Label();
            this.lSessiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGiris
            // 
            this.tbGiris.Location = new System.Drawing.Point(163, 56);
            this.tbGiris.Name = "tbGiris";
            this.tbGiris.Size = new System.Drawing.Size(245, 20);
            this.tbGiris.TabIndex = 0;
            // 
            // ddlSesliSessiz
            // 
            this.ddlSesliSessiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSesliSessiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlSesliSessiz.FormattingEnabled = true;
            this.ddlSesliSessiz.Location = new System.Drawing.Point(163, 95);
            this.ddlSesliSessiz.Name = "ddlSesliSessiz";
            this.ddlSesliSessiz.Size = new System.Drawing.Size(245, 24);
            this.ddlSesliSessiz.TabIndex = 1;
            // 
            // lGiris
            // 
            this.lGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGiris.Location = new System.Drawing.Point(12, 51);
            this.lGiris.Name = "lGiris";
            this.lGiris.Size = new System.Drawing.Size(145, 25);
            this.lGiris.TabIndex = 2;
            this.lGiris.Text = "Kelime Giriniz:";
            // 
            // lSeciniz
            // 
            this.lSeciniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSeciniz.Location = new System.Drawing.Point(12, 95);
            this.lSeciniz.Name = "lSeciniz";
            this.lSeciniz.Size = new System.Drawing.Size(145, 32);
            this.lSeciniz.TabIndex = 3;
            this.lSeciniz.Text = "Seçiniz:";
            // 
            // lbSesli
            // 
            this.lbSesli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSesli.FormattingEnabled = true;
            this.lbSesli.ItemHeight = 24;
            this.lbSesli.Location = new System.Drawing.Point(32, 232);
            this.lbSesli.Name = "lbSesli";
            this.lbSesli.Size = new System.Drawing.Size(245, 148);
            this.lbSesli.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(214, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sesli Sessiz Ayır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSessiz
            // 
            this.lbSessiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSessiz.FormattingEnabled = true;
            this.lbSessiz.ItemHeight = 24;
            this.lbSessiz.Location = new System.Drawing.Point(334, 232);
            this.lbSessiz.Name = "lbSessiz";
            this.lbSessiz.Size = new System.Drawing.Size(245, 148);
            this.lbSessiz.TabIndex = 6;
            // 
            // lSesliler
            // 
            this.lSesliler.AutoSize = true;
            this.lSesliler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSesliler.Location = new System.Drawing.Point(34, 205);
            this.lSesliler.Name = "lSesliler";
            this.lSesliler.Size = new System.Drawing.Size(123, 24);
            this.lSesliler.TabIndex = 7;
            this.lSesliler.Text = "Sesli Harfler";
            // 
            // lSessiz
            // 
            this.lSessiz.AutoSize = true;
            this.lSessiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSessiz.Location = new System.Drawing.Point(340, 205);
            this.lSessiz.Name = "lSessiz";
            this.lSessiz.Size = new System.Drawing.Size(138, 24);
            this.lSessiz.TabIndex = 8;
            this.lSessiz.Text = "Sessiz Harfler";
            // 
            // SesliSessiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSessiz);
            this.Controls.Add(this.lSesliler);
            this.Controls.Add(this.lbSessiz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSesli);
            this.Controls.Add(this.lSeciniz);
            this.Controls.Add(this.lGiris);
            this.Controls.Add(this.ddlSesliSessiz);
            this.Controls.Add(this.tbGiris);
            this.Name = "SesliSessiz";
            this.Text = "SesliSessiz";
            this.Load += new System.EventHandler(this.SesliSessiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGiris;
        private System.Windows.Forms.ComboBox ddlSesliSessiz;
        private System.Windows.Forms.Label lGiris;
        private System.Windows.Forms.Label lSeciniz;
        private System.Windows.Forms.ListBox lbSesli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbSessiz;
        private System.Windows.Forms.Label lSesliler;
        private System.Windows.Forms.Label lSessiz;
    }
}