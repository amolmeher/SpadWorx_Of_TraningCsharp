using System;


namespace Assiment_Three
{
    class Try_SwitchCaseAll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1 to  3 number");
            int num= Convert.ToInt32(Console.ReadLine());
           
            switch (num)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Value didn’t match earlier.");
                    break;
            }
        }
    }
}
