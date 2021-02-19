
namespace WindowsFormsDemo
{
    partial class MenüForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesliSessizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometrikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adamAsmacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.sesliSessizToolStripMenuItem,
            this.geometrikİşlemlerToolStripMenuItem,
            this.adamAsmacaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // sesliSessizToolStripMenuItem
            // 
            this.sesliSessizToolStripMenuItem.Name = "sesliSessizToolStripMenuItem";
            this.sesliSessizToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.sesliSessizToolStripMenuItem.Text = "Sesli Sessiz";
            this.sesliSessizToolStripMenuItem.Click += new System.EventHandler(this.sesliSessizToolStripMenuItem_Click);
            // 
            // geometrikİşlemlerToolStripMenuItem
            // 
            this.geometrikİşlemlerToolStripMenuItem.Name = "geometrikİşlemlerToolStripMenuItem";
            this.geometrikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.geometrikİşlemlerToolStripMenuItem.Text = "Geometrik İşlemler";
            this.geometrikİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.geometrikİşlemlerToolStripMenuItem_Click);
            // 
            // adamAsmacaToolStripMenuItem
            // 
            this.adamAsmacaToolStripMenuItem.Name = "adamAsmacaToolStripMenuItem";
            this.adamAsmacaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.adamAsmacaToolStripMenuItem.Text = "Adam Asmaca";
            this.adamAsmacaToolStripMenuItem.Click += new System.EventHandler(this.adamAsmacaToolStripMenuItem_Click);
            // 
            // MenüForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenüForm";
            this.Text = "Uygulama Seçimi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesliSessizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometrikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adamAsmacaToolStripMenuItem;
    }
}

