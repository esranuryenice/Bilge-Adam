using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_2_OOP
{
    class Customer
    {
        public string nameSurname;
        public bool sex; //false => erkek , true => kadın
        public string busType;

        public override string ToString()
        {
            string gender;

            this.sex == false ? "Female" : "Male"
            if (this.sex == true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            return this.nameSurname + "\t" + gender + "\t" + this.busType;
        }
    }
}
