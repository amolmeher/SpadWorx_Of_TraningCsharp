using System;
/*
 if you want access Parent class Or 
Method that time use base keyword hare parent can not access show method
 */

namespace Practice_Object_Prog_Lang
{
    class baseClass

    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }
class derived : baseClass
    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }
    class Base_Keyword_need
    {
        public static void Main(string[] args)
        {

            // 'obj' is the object of
            // class 'baseClass'
            baseClass obj = new baseClass();


            // invokes the method 'show()'
            // of class 'baseClass'
            obj.show();

            obj = new derived();

            // it also invokes the method
            // 'show()' of class 'baseClass'
            obj.show();

        }
    }
}
