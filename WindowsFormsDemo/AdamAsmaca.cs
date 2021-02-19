using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDemo.Concretes;

namespace WindowsFormsDemo
{
    public partial class AdamAsmaca : Form
    {
        public string[] Kelime = new string[]
        {
            "Adam",
            "Salı",
            "Silme",
            "Çember",
            "Çevirme",
            "Kolkoparan"
        };
        
        public Random rand = new Random();
        
        public AdamAsmaca()
        {
            InitializeComponent();
        }
        private void AdamAsmaca_Load(object sender, EventArgs e)
        {
            lRasgele.Text = "";
           

        }

        private void bGöster_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i <= Kelime.Length - 1; i++)
            {
                lbSonuc.Items.Add(Kelime[i].ToLower());
            }

            int a = rand.Next(Kelime.Length);
            string gelenKelime = Kelime[a];
            int j = 0;
            string isaret = "_";

            while (j <= gelenKelime.Length )
            {
                
                lRasgele.Text = Convert.ToString(j);
                lDebugGelenKelime.Text = gelenKelime;
                j++;
            }

          

            
            

        }

        
    }
}
