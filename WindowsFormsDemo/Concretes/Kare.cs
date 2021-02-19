using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDemo.Abstract;

namespace WindowsFormsDemo.Concretes
{
    public class Kare : IDortgen
    {
        public double UzunKenar { get; set; }
        

        public double AlanHesapla()
        {

            double result = UzunKenar * UzunKenar;
            return result;
        }

        public double CevreHesapla()
        {
             double result = 4 * UzunKenar;
             return result;
        }
    }
}
