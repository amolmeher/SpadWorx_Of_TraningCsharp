using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_concept_All
{
    class Single_level_Inhritance
    {
        static void Main(string[] args)
        { 
        Single1 s = new Single1();

           // s.dis();
            Console.WriteLine("call from child method");
            Single2 ss = new Single2();
            /*ss.dis();
            ss.showw();*/
           
        }
    }
    class Single1
    {
        int a = 10;
       public void showw()
        {
            Console.WriteLine("Im Single1 method");
        }
    }
    class Single2 : Single1
    {
      public void dis()
        {
            Console.WriteLine("I m single2");
        }
    }

}
