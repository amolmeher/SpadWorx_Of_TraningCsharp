﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class End_with
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello C#, How Are You?";
            char[] ch = new char[15];
            s1.CopyTo(10, ch, 0, 12);
            Console.WriteLine(ch);
        }
    }
}
