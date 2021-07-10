using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class str_clone
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = (String)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
