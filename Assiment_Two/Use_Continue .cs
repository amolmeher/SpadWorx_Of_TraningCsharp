using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Two
{
    class Use_Continue
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
//C# continue statement is used to continue loop.
//It continues the current flow of the program and skips the remaining code at specified condition.
//In case of inner loop, it continues only inner loop.
