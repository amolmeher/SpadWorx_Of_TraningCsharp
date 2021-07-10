using System;
namespace Assiment_Two
{
    //  jump statement. It is used to transfer control to the other part of the program.
    // It unconditionally jumps to the specified label.
    class GOTO_LABAL
    {
        public static void Main(string[] args)
        {
         ineligible:
            Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }
        }
    }
}
