using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    interface IPersonalInfo
    {
        string name { get; set; }

        string surname { get; set; }

        string phoneNumber { get; set; }

        string ShowInfo();


    }
}
