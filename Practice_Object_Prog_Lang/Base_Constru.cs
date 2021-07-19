using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Object_Prog_Lang
{
    public class clssA
    {
        int n1, n2;
        public clssA()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        public clssA(int i, int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("Parameterized Constructor Invoked");
            Console.WriteLine("Invoked Values are: " + n1 + " and " + n2);
        }
    }
    class Base_Constru : clssA
    {
        public Base_Constru() : base()
        {
            Console.WriteLine("im dried  defgult cont ");
        }
        public Base_Constru(int i, int j) : base(i, j)
        {
            Console.WriteLine("im driverd parameter cont ");
        }

        static void Main()
        {

            // invoke no argumanet constructor
            Base_Constru d1 = new Base_Constru();

            Console.WriteLine();

            // invoke parameterized constructor
            Base_Constru d2 = new Base_Constru(10, 20);
        }
    }
}
