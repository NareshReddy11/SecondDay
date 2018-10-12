using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class abstraction2
    {
        static void Main(string[] args)
        {
            arithematic obj1 = new arithematic();
            Console.WriteLine("enter two numbers");
            obj1.pnum1 = Convert.ToInt32(Console.ReadLine());
            obj1.pnum2 = Convert.ToInt32(Console.ReadLine());
            obj1.add();
            Console.WriteLine("addition is:" + obj1.presult);
            obj1.sub();
            Console.WriteLine("subtraction is:" + obj1.presult);
            obj1.mul();
            Console.WriteLine("multiplication is:" + obj1.presult);
        }
    }
}
