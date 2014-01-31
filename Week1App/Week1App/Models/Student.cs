using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1App.Models
{
    class Student
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set {
                if (value == null || value == string.Empty)
                {
                    throw new ApplicationException("FirstName must be defined");
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string getFirstName() {
            return _firstName;
        }
        public void setFirstName(string fName) {
            _firstName = fName;
        }
    }
}
