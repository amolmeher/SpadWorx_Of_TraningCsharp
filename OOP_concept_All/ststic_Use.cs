using System;


namespace OOP_concept_All
{
    
    class ststic_Use
    {
        static int a = 10;
        int b = 11;
        static ststic_Use()
        {
            a++;
            Console.WriteLine("I am Static cont"+a);
        }
        public static void Main()
        {
            ststic_Use aa = new ststic_Use();

            Console.WriteLine(aa.b);

        }
    }
}
