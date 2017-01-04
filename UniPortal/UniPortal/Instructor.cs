using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class Instructor : IPersonalInfo, IEmployeeInfo
    {
        private string _name;
        public string name
        {

            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        private string _surname;
        public string surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }
        private string _phoneNumber;
        public string phoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }
        private string _department;
        public string department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }
        private string _task;
        public string task
        {
            get
            {
                return _task;
            }

            set
            {
                _task = value;
            }
        }

        public string ShowInfo()
        {
            return string.Format("Name: {0} \t Surname: {1} \t Phone Number: {2} \t Department: {3} \t Task: {4}", name, surname, phoneNumber, department, task);
        }
    }
}
