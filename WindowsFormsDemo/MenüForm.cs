using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class MenüForm : Form
    {
        public MenüForm()
        {
            InitializeComponent();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.MdiParent = this;
            calculator.WindowState = FormWindowState.Maximized;
            calculator.Show();
        }

        private void sesliSessizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SesliSessiz sesliSessiz = new SesliSessiz();
            sesliSessiz.MdiParent = this;
            sesliSessiz.WindowState = FormWindowState.Maximized;
            sesliSessiz.Show();
        }

        private void geometrikİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeometrikIslemler geometrikIslemler = new GeometrikIslemler();
            geometrikIslemler.MdiParent = this;
            geometrikIslemler.WindowState = FormWindowState.Maximized;
            geometrikIslemler.Show();
        }

        private void adamAsmacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdamAsmaca adamAsmaca = new AdamAsmaca();
            adamAsmaca.MdiParent = this;
            adamAsmaca.WindowState = FormWindowState.Maximized;
            adamAsmaca.Show();
        }
    }
}
