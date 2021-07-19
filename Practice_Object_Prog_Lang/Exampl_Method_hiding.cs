using System;

namespace Practice_Object_Prog_Lang
{
    public class My_Family
    {
        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }
    public class My_Member : My_Family
    {
        public new void member()
        {
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya, " +
                                   "Age: 39 \nName: Rohan, Age: 20 ");
        }
    }
        class Exampl_Method_hiding
    {
        static public void Main()
        {
            My_Member obj = new My_Member();
            obj.member();
        }
    }
}
