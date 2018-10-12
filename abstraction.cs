using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class abstraction
    {
        static void Main(string[] args)
        {
            employee2 obj1 = new employee2();
            Console.WriteLine("enter emp id,name,address,age");
            obj1.pempId = Convert.ToInt32(Console.ReadLine());
            obj1.pname = Console.ReadLine();
            obj1.paddress = Console.ReadLine();
            obj1.page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("employee deatiles are");
            Console.WriteLine("emp id is:" + obj1.pempId);
            Console.WriteLine("emp name is:" + obj1.pname);
            Console.WriteLine("emp address is:" + obj1.page);
        }
    }
}
