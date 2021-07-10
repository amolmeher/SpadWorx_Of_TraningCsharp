using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class pravite_Test
    {
        private string name = "Shantosh Kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
        static void Main(string[] args)
        {
            pravite_Test obj1 = new pravite_Test();
            // Accessing private variable  
            Console.WriteLine("Hello " + obj1.name);
            // Accessing private function  
            obj1.Msg("Peter Decosta");
        }
    }
}




/*
  private string name = "Shantosh Kumar";  
        private void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            PrivateTest privateTest = new PrivateTest();  
            // Accessing private variable  
            Console.WriteLine("Hello " + privateTest.name);  
            // Accessing private function  
            privateTest.Msg("Peter Decosta");  
        }  
    }  


*/