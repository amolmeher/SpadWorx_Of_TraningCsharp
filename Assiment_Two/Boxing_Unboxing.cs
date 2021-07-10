using System;


namespace Assiment_Two
{
    class Boxing_Unboxing
    {
        static void Main()
        {
            int i = 123;

            // Boxing copies the value of i into object o.
            object o = i;

            // Change the value of i.
            i = 456;

            // The change in i doesn't affect the value stored in o.
            System.Console.WriteLine("The value-type value = {0}", i);
            System.Console.WriteLine("The object-type value = {0}", o);


            int ii = 123;
            object oo = i;  // implicit boxing

            try
            {
                int j = (short)oo;  // attempt to unbox

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }


        }
    }
}

