using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class InternalTest
    {
        internal string name = "Shantosh Kumar";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
            // Accessing internal variable  
            Console.WriteLine("Hello " + internalTest.name);
            // Accessing internal function  
            internalTest.Msg("Peter Decosta");
        }
    }
}

