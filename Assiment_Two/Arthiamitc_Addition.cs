using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Two
{
    class Arthiamitc_Addition
    {
        static void Main(string[] args)
        {

            //Arithmetic Operators
            int a = 5, b = 4;

            Console.WriteLine("Addtion =" + (a + b));
            Console.WriteLine("Substraction =" + (a - b));
            Console.WriteLine("Multiplication =" + (a * b));
            Console.WriteLine("Division =" + (a / b));



            //Assignment Operator
            Console.WriteLine("\n Using Assignment Operator.");
            int X = 50;
            int Y;
            Y = X;
            Console.WriteLine("After Assigning Value of Y = " + Y);
      



            //Relational Operator
            Console.WriteLine("\n Using Relational Operator...................");

            int num1 = 45, num2 = 65;
            Console.WriteLine("\n num1 = " + num1 + " num2 = " + num2);

            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 >= num2);


            //Logical Operator
            Console.WriteLine("\n Using Logical Operator...................");
            Console.WriteLine((45 > 36) || (89 < 90));
            Console.WriteLine((45 > 36) && (89 < 90));


           

     
        }
    }
}
