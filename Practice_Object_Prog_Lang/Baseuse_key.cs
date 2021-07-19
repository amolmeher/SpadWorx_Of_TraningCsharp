using System;

namespace Practice_Object_Prog_Lang
{
    public class web
    {
        string name = "GeeksForGeeks";

        // 'showdata()' is member method,
        // declare as virtual
        public virtual void showdata()
        {
            Console.WriteLine("Website Name: " + name);
        }
    }

    class stream : web
    {
        string s = "Computer Science";
        //'showdata()' is overridden
        // in derived class
        public override void showdata()
        {
            // Calling 'showdata()' of base
            // class using 'base' keyword
            base.showdata();

            Console.WriteLine("About: " + s);
        }
    }
    class Baseuse_key
    {
        static void Main()
        { 
         stream E = new stream();

            E.showdata();

        }
    }
}
