using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assiment_All
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
      : base(message)
        {

        }
    }
    class UseeDefine_Exception
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }

        public static void Main(string[] args)
        {
            /* try
             {
                 validate(12);
             }
             catch (InvalidAgeException e)
             {
                 Console.WriteLine(e);
             }
             Console.WriteLine("Rest of the code");*/
            
                abstrct_Try_Demo obj = new abstrct_Try_Demo();
                Console.WriteLine(obj.a);
            
        }
    }
}
