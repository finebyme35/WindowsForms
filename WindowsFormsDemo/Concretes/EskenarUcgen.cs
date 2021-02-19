using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDemo.Abstract;

namespace WindowsFormsDemo.Concretes
{
    public class EskenarUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        public double AlanHesapla()
        {
            double result = (Math.Sqrt(3) / 4) * (TabanKenar * TabanKenar);
            return result;
        }

        public double CevreHesapla()
        {
            double result = 3 * TabanKenar;
            return result;
        }
    }
}
