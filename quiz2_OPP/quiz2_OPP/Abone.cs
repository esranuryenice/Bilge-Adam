using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2_OPP
{
    class Abone
    {
        public string adSoyad;
        public bool aboneTipi;
        public int oncekiIndex;
        public int sonrakiIndex;
        public double ucret;

        public override string ToString()
        {
           
            return this.adSoyad + this.ucret;
        }
        
                   
                   
    }

}
