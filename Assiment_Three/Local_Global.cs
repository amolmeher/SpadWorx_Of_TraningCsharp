using System;
using myAlias = System.Collections;
namespace Assiment_Three
{
    class Local_Global
    {
        int temp = 11;
        public static void Main()
        {
            int a;
            a = 100;
            // local variable
            Console.WriteLine("Value:" + a);


            myAlias::Hashtable hTable = new myAlias::Hashtable();
            hTable.Add("A", "1");
            hTable.Add("B", "2");
            hTable.Add("C", "3");
            foreach(string str in hTable.Keys)
            {
                global::System.Console.WriteLine(str + " " + hTable[hTable]);
            }
            void Fun()
            {
                int temp = 21;
                Console.WriteLine(a);//21
            }
        }
    }
}
