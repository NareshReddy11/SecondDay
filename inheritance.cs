using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class inheritance
    {
        int Bcode;
        string Bname;
        string Baddress;
        public void GetBranchData()
        {
            Console.WriteLine("enter branch code,name ,address");
            Bcode = Convert.ToInt32(Console.ReadLine());
            Bname = Console.ReadLine();
            Baddress = Console.ReadLine();
        }
        public void displayBranchData()
        {
            Console.WriteLine("branch code is:" + Bcode);
            Console.WriteLine("branch name is:" + Bname);
            Console.WriteLine("branch address is:" + Baddress);
        }
    }
    class employee3 : inheritance
    {
        int empId;
        string name;
        string address;
        int age;
        public void GetEmpData()
        {
            Console.WriteLine("enter empid,name,address,age");
            empId = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            address = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void displayEmpData()
        {
            Console.WriteLine("empId is:" + empId);
            Console.WriteLine("emp name is:" + name);
            Console.WriteLine("emp address is :" + address);
            Console.WriteLine("empa age is:" + age);
        }
    }
    class inheritance1
    {
        static void Main(string[] args)
        {
            employee3 obj1 = new employee3();
            obj1.GetBranchData();
            obj1.GetEmpData();

            obj1.displayBranchData();
            obj1.displayEmpData();
        }
    }
}
