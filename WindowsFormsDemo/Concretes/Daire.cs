using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDemo.Concretes
{
    public class Daire
    {
        public double YariCap { get; set; }
        private double pi = 3.14;

        public double AlanHesapla()
        {
            double result = pi * (YariCap * YariCap);
            return result;
        }

        public double CevreHesapla()
        {
            double result = 2 * pi * YariCap;
            return result;
        }
    }
}
