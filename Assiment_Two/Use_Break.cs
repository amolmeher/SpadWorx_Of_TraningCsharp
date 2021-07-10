using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Two
{
    class Use_Break
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
