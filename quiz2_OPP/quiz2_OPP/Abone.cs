using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2_OPP
{
    public class Abone
    {
        public string adSoyad;
        public bool aboneTipi;
        public int oncekiIndex;
        public int sonrakiIndex;
      

        public double OdemeHesapla(double onceki, double sonraki, bool aboneTuru)
        {
            double result = 0;

            if (aboneTipi == false)
            {
                result = (sonraki - onceki) * 0.3;
            }
            else
            {
                result = (sonraki - onceki) * 0.5;
            }
            return result;
        }

        public override string ToString()
        {           
            return this.adSoyad;
        }
        
                   
                   
    }

}
