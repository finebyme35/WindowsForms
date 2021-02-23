using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            "İSTANBUL",
            "İZMİR",
            "ANKARA",
            "LOSANGELES",
            "ABUDHABİ",
            "ÇANAKKALE"
        };

        public string buluncakKelime = "";
        public int resimSayisi = 0;


        public Random rand = new Random();

        public AdamAsmaca()
        {
            InitializeComponent();
        }

        private void AdamAsmaca_Load(object sender, EventArgs e)
        {
            lRasgele.Text = "";
            lBilgi.Text = "BU BİR ŞEHİR";
            lDebugGelenKelime.Text = "";
            buluncakKelime = Kelime[rand.Next(6)].ToUpper();
            for (int i = 0; i < buluncakKelime.Length; i++)
            {

                lRasgele.Text += "*";
            }

            resimSayisi = 0;
            pbAdam.Image = null;
            lDebugGelenKelime.Text = buluncakKelime;
            lbSonuc.Items.Clear();
            lDebugGelenKelime.Visible = false;



        }

        private void bGöster_Click(object sender, EventArgs e)
        {
            islemler();

        }

        void islemler()
        {
            if (string.IsNullOrWhiteSpace(tbGiris.Text) || tbGiris.Text.Length > 1)
            {
                MessageBox.Show("Lütfen 1 Harf Giriniz.");
                tbGiris.Text = "";
            }
            else
            {
                bool result;

                char aranacakChar = char.Parse(tbGiris.Text.ToUpper());
                result = char.IsLetter(aranacakChar);
                if (result == true)
                {
                    char[] karakterler = buluncakKelime.ToCharArray();
                    bool varmi = false;

                    for (int i = 0; i <= lbSonuc.Items.Count - 1; i++)
                    {
                        if (lbSonuc.Items[i].ToString() == aranacakChar.ToString())
                        {
                            MessageBox.Show("Bu harf daha önce girilmiştir. Başka Harf deneyin.");
                            return;
                        }
                    }

                    lbSonuc.Items.Add(aranacakChar.ToString());

                    for (int i = 0; i < karakterler.Length; i++)
                    {
                        if (karakterler[i] == aranacakChar)
                        {
                            lRasgele.Text = lRasgele.Text.Remove(i, 1);
                            lRasgele.Text = lRasgele.Text.Insert(i, aranacakChar.ToString());
                            varmi = true;
                        }
                    }

                    if (lRasgele.Text == buluncakKelime)
                    {
                        MessageBox.Show("Kelime'yi bildiniz. TEBRİKLER.");
                        lRasgele.Text = buluncakKelime;
                        return;
                    }

                    tbGiris.Text = "";

                    if (varmi == false)
                    {
                        resimSayisi++;
                        pbAdam.Image = Image.FromFile(@"D:\EğitimBilgeAdam\WindowsFormsExample\WindowsFormsDemo\WindowsFormsDemo\Resimler\" + resimSayisi + ".png");

                        if (resimSayisi == 7)
                        {
                            MessageBox.Show("Bütün Haklarınız doldu oyunu kaybettiniz.");
                            lRasgele.Text = buluncakKelime;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Harf Giriniz.");
                }
            }
        }


    }
}


