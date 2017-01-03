using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    public class Dam
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            return title;
        }


    }
}
