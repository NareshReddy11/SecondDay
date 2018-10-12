using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class employee2
    {
        int empId;
        string name;
        string address;
        int age;
        public int pempId
        {
            set
            {
                empId = value;
            }
            get
            {
                return empId;
            }
        }
        public string pname
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string paddress
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public int page
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
    }
}
