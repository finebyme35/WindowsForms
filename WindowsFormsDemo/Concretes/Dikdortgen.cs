using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDemo.Abstract;

namespace WindowsFormsDemo.Concretes
{
    public class Dikdortgen : IDortgen
    {
        public double UzunKenar { get; set; }
        public double KisaKenar { get; set; }
        public double AlanHesapla()
        {
            double result = UzunKenar * KisaKenar;
            return result;
        }

        public double CevreHesapla()
        {
            double result = 2 * (UzunKenar + KisaKenar);
            return result;
        }
    }
}
