using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class multipleinheritance
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
    class employee4 : multipleinheritance
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
    class salary : employee3
    {
        double basic, da, hra, grass;
        public void getsalari()
        {
            Console.WriteLine("enter basic salary");
            basic = Convert.ToDouble(Console.ReadLine());
        }
        public void calculate()
        {
            da = basic * 0.03;
            hra = basic * 0.3;
            grass = basic + da + hra;
        }
        public void displaysalary()
        {
            Console.WriteLine("basic salary is:" + basic);
            Console.WriteLine("da is:" + da);
            Console.WriteLine("hra is:" + hra);
            Console.WriteLine("grass salary is:" + grass);
        }
    }
    class inheritance2
    {
        static void Main(string[] args)
        {
            salary obj1 = new salary();
            obj1.GetBranchData();
            obj1.GetEmpData();
            obj1.getsalari();
            obj1.calculate();

            obj1.displayBranchData();
            obj1.displayEmpData();
            obj1.displaysalary();
        }
    }
}