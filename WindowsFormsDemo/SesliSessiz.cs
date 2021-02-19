using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class SesliSessiz : Form
    {
        char[] sesli = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', };
        string kelime;
        int sayi = 0;
        char[] sessiz = { 'r', 't', 'y', 'r', 'p', 'ğ', 'ş', 'l', 'k',
            'ç','m','n','b','v','c','z','s','d','f','g','h','j'};
        public SesliSessiz()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            lbSesli.Items.Clear();
            lbSessiz.Items.Clear();
            kelime = tbGiris.Text;

            foreach (char harf1 in kelime.ToLower())
            {
                sayi = 0;
                if (ddlSesliSessiz.SelectedIndex == 0)
                {
                    for (int i = 0; i < sesli.Length; i++)
                    {
                        if (harf1 == sesli[i])
                        {
                            lbSesli.Items.Add(harf1);
                            sayi++;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < sessiz.Length; i++)
                    {
                        if (harf1 == sessiz[i])
                        {
                            lbSessiz.Items.Add(harf1);
                            sayi++;
                            break;
                        }
                    }
                }
            }

        }


        private void SesliSessiz_Load(object sender, EventArgs e)
        {
            ddlSesliSessiz.Items.Add("Sesli");
            ddlSesliSessiz.Items.Add("Sessiz");
            ddlSesliSessiz.SelectedIndex = 0;
        }
    }
    }

