using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Three
{
    class Q1_Switch_DataType_pass_dif
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter a number:");
             int num = Convert.ToInt32(Console.ReadLine());

             switch (num)
             {
                 case 10: Console.WriteLine("It is 10");
                     break;
                 case 20: Console.WriteLine("It is 20"); 
                     break;
                 case 30: Console.WriteLine("It is 30");
                     break;
                 default: Console.WriteLine("Not 10, 20 or 30"); break;
             }
          */
            /*Console.WriteLine("Enter a Char:");
            char ch = Console.ReadLine()[0];
           switch (ch)
           {
               case 'A':
                   Console.WriteLine("It is 10");
                   break;
               case 'B':
                   Console.WriteLine("It is 20");
                   break;
               case 'C':
                   Console.WriteLine("It is 30");
                   break;
               default: Console.WriteLine("Not 10, 20 or 30"); break;
           }*/



            string statementType = "ternary";

            switch (statementType)
            {
                case "if.else":
                    Console.WriteLine("if...else statement");
                    break;
                case "ternary":
                    Console.WriteLine("Ternary operator");
                    break;
                case "switch":
                    Console.WriteLine("switch statement");
                    break;
            }
        }
    }
}
