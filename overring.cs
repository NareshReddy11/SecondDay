using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class overring
    {
        public virtual void Greetings()

        {

            Console.WriteLine("baseClass Saying Hello!");

        }

    }

    class subClass : overring

    {

        public override void Greetings()

        {

            base.Greetings();

            Console.WriteLine("subClass Saying Hello!");

        }

    }

    class clsoverriding

    {

        static void Main(string[] args)

        {

            overring obj1 = new subClass();

            obj1.Greetings();

            Console.ReadLine();

        }

    }
}
