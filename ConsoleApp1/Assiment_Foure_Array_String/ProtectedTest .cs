using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class ProtectedTest
    {
        protected string name = "Shashikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program2 : ProtectedTest
    {
        static void Main(string[] args)
        {
            Program2 program2 = new Program2();
            // Accessing protected variable  
            Console.WriteLine("Hello " + program2.name);
            // Accessing protected function  
            program2.Msg("Swami Ayyer");
        }
    }
}

