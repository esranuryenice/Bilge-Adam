using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class DamWaterRatio : Dam
    {    

        public DamWaterRatio(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public override string ToString()
        {
            return this.title + "\t\t" + "% " + this.description;
        }
    }
}
