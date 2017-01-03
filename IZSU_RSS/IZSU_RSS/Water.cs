using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Water
    {
        public DateTime date { get; set; }

        public string title { get; set; }

        public string description { get; set; }



        public Water(string title, string description)
        {
            this.title = title;
            this.description = description;
            
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
