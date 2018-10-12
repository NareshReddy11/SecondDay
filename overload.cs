using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class overload
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public float add(float c,int k)
        {
            return c + k;
        }
    }
    class overloadded
    {
        static void Main(string[] args)
        {
            overload obj1 = new overload();
            Console.WriteLine("sum is:" + obj1.add(2, 4));
            Console.WriteLine("sum is:" + obj1.add(2.3f, 4));
        }
    }
}
