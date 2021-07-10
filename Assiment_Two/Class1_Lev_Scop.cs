using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Two
{
    class Class1_Lev_Scop
    {
        int abc = 1000; // class level variable with class level scope 
        public void display()
        {
            int a = 10;
            Console.WriteLine(a); // method to access the class level variable 
        } // method ends here
    }
}
