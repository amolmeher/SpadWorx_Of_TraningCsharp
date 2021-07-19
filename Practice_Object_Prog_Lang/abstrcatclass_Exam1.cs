using System;
/*
   C#, you are not allowed to create objects of the abstract class.
Class that contains the abstract keyword with all of its methods is known as pure Abstract Base Class.
You are not allowed to declare the abstract methods outside the abstract class.
You are not allowed to declare abstract class as
 */

namespace Practice_Object_Prog_Lang
{
    abstract class Shape
    {
        // abstract method
        public abstract int area();
    }
    class Square : Shape
    {
        // private data member
        private int side;
        public Square(int x = 0)
        {
            side = x;
        }
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class abstrcatclass_Exam1
    {
        static void Main(string[] args)
        {

            Shape sh = new Square(4);

            double result = sh.area();
             Console.Write("{0}", result);

        }
    }
}
