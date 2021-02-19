using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDemo.Abstract;

namespace WindowsFormsDemo.Concretes
{
    public class DikUcgen:IUcgen
    {
        public double TabanKenar { get; set; }
        public double Yükseklik { get; set; }
        public double AlanHesapla()
        {
            double result = (TabanKenar * Yükseklik) / 2;
            return result;
        }

        public double CevreHesapla()
        {
            double h1 = (TabanKenar * TabanKenar) + (Yükseklik * Yükseklik);
            double hipotenüs = Math.Sqrt(h1);
            double result = TabanKenar + Yükseklik + hipotenüs;
            return result;
        }
    }
}
