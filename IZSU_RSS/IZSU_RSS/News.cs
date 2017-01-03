using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class News
    {
        public string newsTitle { get; set; }

        public string newsDescription { get; set; }

        public DateTime date { get; set; }

        public string link { get; set; }

        public News(string newsTitle)
        {
            this.newsTitle = newsTitle;                    
           
        }

        public override string ToString()
        {
            return this.newsTitle ;
        }
    }
}
