using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class employee
    {
        int empId;
        string name;
        string address;
        int age;
        public void GetData()
        {
            Console.WriteLine("enter empid,name,address,age");
            empId = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            address = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void dispay()
        {
            Console.WriteLine("employee id:" + empId);
            Console.WriteLine("empoyee name:" + name);
            Console.WriteLine("employee address:" + address);
            Console.WriteLine("employee age:" + age);
        }
    }
    class encapulate
    {
        static void Main(string[] args)
        {
            employee obj1 = new employee();
            obj1.GetData();
            obj1.dispay();
        }
    }
}
