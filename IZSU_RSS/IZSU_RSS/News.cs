using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class News : Dam
    {       

        public string link { get; set; }

        public News(string title, string link)
        {
            this.title = title;
            this.link = link;          
           
        }
       
    }
}
