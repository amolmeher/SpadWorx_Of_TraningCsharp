using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Object_Prog_Lang
{
    class baseClass1
    {

        // show() is 'virtual' here
        public virtual void showw()
        {
            Console.WriteLine("Base class");
        }
    }


    // class 'baseClass' inherit
    // class 'derived'
    class derived1 : baseClass1
    {

        //'show()' is 'override' here
        public override void showw()
        {
            
            Console.WriteLine("Derived class");
        }
    }
    class base_Use
    {
        public static void Main(string[] args)
        {
             baseClass1 obj = new baseClass1();
            obj.showw();

             obj = new derived1();

           
            obj.showw();
        }
    }
}
