using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Two
{
    class Type_Cast
    {
        static void Main(string[] args)
        {
            // Implicit Type Casting

            int a = 12;
            long b = a;
            Console.WriteLine("b = " + b);

            char world = 'V';

            int s = world;
            Console.WriteLine(" ASCII Value of V = " + s);



            // Explicit Type Casting

            double x = 58.45;

            // int y = x;
            int y = (int)x;

            Console.WriteLine("y = " + y);

        }
    }
}

