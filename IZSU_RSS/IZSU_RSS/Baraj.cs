using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Baraj
    {
        public static DateTime date { get; set; }
             
        public string name { get; set; }

        public string fillRate { get; set; }

        

        public Baraj(string name, string fillRate)
        {
            this.name = name;
            this.fillRate = fillRate;
        }

        public override string ToString()
        {
            return this.name + "\t\t" + "% " + this.fillRate;
        }
    }
}
