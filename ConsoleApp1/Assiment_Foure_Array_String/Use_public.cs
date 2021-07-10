using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class Use_public
    {
        public string name = "Shantosh Kumar";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Use_public publicTest = new Use_public();
            // Accessing public variable  
            Console.WriteLine("Hello " + publicTest.name);
            // Accessing public function  
            publicTest.Msg("Peter Decosta");
        }
    }
}

