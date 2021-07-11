using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concept_All
{
    class MultiLevel_Inherita
    {
        public static void Main()
        {
            A2 a2 = new A2();
            Console.WriteLine(a2.a+" \t A2 ->"+a2.b);
            A3 a3 = new A3();
            Console.WriteLine(a3.a + " A2   " + a3.b + "  A3 " + a3.c);
        }
    }
}
class A1
{
  public int a = 100;
}
class A2 : A1
{
   public int b = 200;
}class A3 :A2
{
   public int c = 300;
}