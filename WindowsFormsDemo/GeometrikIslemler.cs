using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDemo.Abstract;
using WindowsFormsDemo.Concretes;

namespace WindowsFormsDemo
{
    public partial class GeometrikIslemler : Form
    {
        private Daire daire = new Daire();
        private Dikdortgen dikdortgen = new Dikdortgen();
        private DikUcgen dikUcgen = new DikUcgen();
        private EskenarUcgen eskenarUcgen = new EskenarUcgen();
        Kare kare = new Kare();
        public GeometrikIslemler()
        {
            InitializeComponent();
        }
        private void GeometrikIslemler_Load(object sender, EventArgs e)
        {
            ddlGeometrikSekil.Items.Add("Kare");
            ddlGeometrikSekil.Items.Add("Dikdörtgen");
            ddlGeometrikSekil.Items.Add("Eşkenar Üçgen");
            ddlGeometrikSekil.Items.Add("Dik Üçgen");
            ddlGeometrikSekil.Items.Add("Daire");
            ddlGeometrikSekil.SelectedIndex = 0;
            ddlKenarSecimi.Items.Add("UzunKenar");
            ddlKenarSecimi.Items.Add("TabanKenar");
            ddlKenarSecimi.SelectedIndex = 0;
            ddlAlanCevreSecimi.Items.Add("AlanHesapla");
            ddlAlanCevreSecimi.Items.Add("CevreHesapla");
            ddlAlanCevreSecimi.SelectedIndex = 0;
            tbSayi.Text = "";
            tbSayiki.Visible = false;
            lSayiki.Visible = false;


        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        void Hesapla()
        {
            if (ddlGeometrikSekil.SelectedIndex == 0 && ddlKenarSecimi.SelectedIndex == 0)
            {
                if (ddlAlanCevreSecimi.SelectedIndex == 0)
                {
                    KareAlan();
                }
                else
                {
                    KareCevre();
                }

            }
            else if (ddlGeometrikSekil.SelectedIndex == 1 && ddlKenarSecimi.SelectedIndex == 1)
            {

                if (ddlAlanCevreSecimi.SelectedIndex == 0)
                {
                    DikdortgenAlan();
                }
                else
                {
                    DikdortgenCevre();
                }

            }
            else if (ddlGeometrikSekil.SelectedIndex == 2 && ddlKenarSecimi.SelectedIndex == 1)
            {
                if (ddlAlanCevreSecimi.SelectedIndex == 0)
                {
                    EskenarUcgenAlan();
                }
                else
                {
                    EskenarUcgenCevre();
                }

            }
            else if (ddlGeometrikSekil.SelectedIndex == 3 && ddlKenarSecimi.SelectedIndex == 2)
            {

                if (ddlAlanCevreSecimi.SelectedIndex == 0)
                {
                    DikUcgenAlan();
                }
                else
                {
                    DikdortgenCevre();
                }

            }
            else if (ddlGeometrikSekil.SelectedIndex == 4)
            {

                if (ddlAlanCevreSecimi.SelectedIndex == 0)
                {
                    DaireAlan();
                }
                else
                {
                    DaireCevre();
                }

            }
        }
        void KareAlan()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            kare.UzunKenar = sayi;
            lbSonuc.Items.Add(kare.AlanHesapla());
        }
        void KareCevre()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            kare.UzunKenar = sayi;
            lbSonuc.Items.Add(kare.CevreHesapla());
        }
        void DikdortgenAlan()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            double sayi2 = Convert.ToDouble(tbSayiki.Text);
            dikdortgen.UzunKenar = sayi;
            dikdortgen.KisaKenar = sayi2;
            lbSonuc.Items.Add(dikdortgen.AlanHesapla());
        }

        void DikdortgenCevre()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            double sayi2 = Convert.ToDouble(tbSayiki.Text);
            dikdortgen.UzunKenar = sayi;
            dikdortgen.KisaKenar = sayi2;
            lbSonuc.Items.Add(dikdortgen.CevreHesapla());
        }

        void DikUcgenAlan()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            double sayi2 = Convert.ToDouble(tbSayiki.Text);
            dikUcgen.TabanKenar = sayi;
            dikUcgen.Yükseklik = sayi2;
            lbSonuc.Items.Add(dikUcgen.AlanHesapla());
        }
        void DikUcgenCevre()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            double sayi2 = Convert.ToDouble(tbSayiki.Text);
            dikUcgen.TabanKenar = sayi;
            dikUcgen.Yükseklik = sayi2;
            lbSonuc.Items.Add(dikUcgen.CevreHesapla());
        }
        void EskenarUcgenAlan()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            eskenarUcgen.TabanKenar = sayi;
            lbSonuc.Items.Add(eskenarUcgen.AlanHesapla());
        }
        void EskenarUcgenCevre()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            eskenarUcgen.TabanKenar = sayi;
            lbSonuc.Items.Add(eskenarUcgen.CevreHesapla());
        }
        void DaireAlan()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            daire.YariCap = sayi;
            lbSonuc.Items.Add(daire.AlanHesapla());
        }
        void DaireCevre()
        {
            lbSonuc.Items.Clear();
            double sayi = Convert.ToDouble(tbSayi.Text);
            daire.YariCap = sayi;
            lbSonuc.Items.Add(daire.CevreHesapla());
        }

        private void ddlGeometrikSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 4;
            while (i<5)
            {
                if (ddlGeometrikSekil.SelectedIndex == 1)
                {
                    lSayiki.Text = "Kısa Kenar Uzunluğunu Giriniz: ";
                    lSayiki.Visible = true;
                    tbSayiki.Visible = true;
                    
                }
                if (ddlGeometrikSekil.SelectedIndex == 3)
                {
                    lSayiki.Text = "Yüksekliği Giriniz: ";
                    lSayiki.Visible = true;
                    tbSayiki.Visible = true;
                    
                }
                if(ddlGeometrikSekil.SelectedIndex == 0 || ddlGeometrikSekil.SelectedIndex == 2)
                {
                    lGiris.Text = "Kenar Uzunluğunu Giriniz: ";
                    lSayiki.Visible = false;
                    tbSayiki.Visible = false;
                }

                if (ddlGeometrikSekil.SelectedIndex == 4)
                {
                    lGiris.Text = "Yarıçapı Giriniz: ";
                    lSayiki.Visible = false;
                    tbSayiki.Visible = false;
                    lKenarSecimi.Visible = false;
                    ddlKenarSecimi.Visible = false;
                }

                i++;

            }
            
        }
    }
}
