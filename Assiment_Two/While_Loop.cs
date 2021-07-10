using System;
/*
 * while loop is used to iterate a part of the program several times.
 * If the number of iteration is not fixed,
 * it is recommended to use while loop than for loop.
 */

namespace Assiment_Two
{
    class While_Loop
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
