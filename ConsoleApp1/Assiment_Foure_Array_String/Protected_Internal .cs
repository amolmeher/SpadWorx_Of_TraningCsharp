using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class Protected_Internal
    {
        protected internal string name = "Shantosh Kumar";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program4
    {
        static void Main(string[] args)
        {
            Protected_Internal obj= new Protected_Internal();
            // Accessing protected internal variable  
            Console.WriteLine("Hello " + obj.name);
            // Accessing protected internal function  
            obj.Msg("Peter Decosta");
        }
    }
}
