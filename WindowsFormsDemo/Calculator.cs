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
    public partial class Calculator : Form
    {
        private string girilen = "";
        private string ilkSayi = "";
        private string ikinciSayi = "";
        private double result = 0;
        private string operation = "";
        public Calculator()
        {
            InitializeComponent();
        }
       

        private void bToplama_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "+";
            girilen = "";
        }

        private void bCikarma_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "-";
            girilen = "";
        }

        private void bCarpma_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "*";
            girilen = "";
        }

        private void bBolme_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "/";
            girilen = "";
        }

        private void bUsAlma_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "u";
            girilen = "";
        }

        private void bKokAlma_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "k";
            girilen = "";
        }

        private void bCokluSilme_Click(object sender, EventArgs e)
        {
            tbGiris.Text= "";
            girilen = "";
            ilkSayi = "";
            ikinciSayi = "";
        }

       
        private void bMod_Click(object sender, EventArgs e)
        {
            ilkSayi = girilen;
            operation = "%";
            girilen = "";
        }

        private void bVirgul_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += ",";
            tbGiris.Text += girilen;
        }
        private void bSifir_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "0";
            tbGiris.Text += girilen;
        }

        private void bBir_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "1";
            tbGiris.Text += girilen;
        }

        private void bİki_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "2";
            tbGiris.Text += girilen;
        }

        private void bUc_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "3";
            tbGiris.Text += girilen;
        }

        private void bDort_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "4";
            tbGiris.Text += girilen;
        }

        private void bBes_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "5";
            tbGiris.Text += girilen;
        }

        private void bAlti_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "6";
            tbGiris.Text += girilen;
        }

        private void bYedi_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "7";
            tbGiris.Text += girilen;
        }

        private void bSekiz_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "8";
            tbGiris.Text += girilen;
        }

        private void bDokuz_Click(object sender, EventArgs e)
        {
            tbGiris.Text = "";
            girilen += "9";
            tbGiris.Text += girilen;
        }


        private void bEsittir_Click(object sender, EventArgs e)
        {
            ikinciSayi = girilen;
            double num1, num2;
            double.TryParse(ilkSayi, out num1);
            double.TryParse(ikinciSayi, out num2);
            tbGiris.Text = "";
            girilen = "";
            ilkSayi = "";
            ikinciSayi = "";

            if (operation == "+")
            {
                result = num1 + num2;
                tbGiris.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                tbGiris.Text = result.ToString();
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                tbGiris.Text = result.ToString();
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    tbGiris.Text = result.ToString();
                }
                else
                {
                    tbGiris.Text = "DIV/Zero!";
                }

            }
            else if (operation == "k")
            {
               
                result = Math.Sqrt(num1);
                tbGiris.Text = result.ToString();
               
            }
            else if (operation == "u")
            {
                result = Math.Pow(num1, num2);
                tbGiris.Text = result.ToString();
            }
            else if (operation == "%")
            {
                result = num1 % num2;
                tbGiris.Text = result.ToString();
            }
        }

    }
}
