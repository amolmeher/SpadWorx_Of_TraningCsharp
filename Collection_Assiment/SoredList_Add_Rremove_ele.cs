using System;
using System.Collections.Generic;
using System.Collections;
namespace Collection_Assiment
{
    class SoredList_Add_Rremove_ele
    {
        static public void Main()
        {

            // Creating a sortedlist
            // Using SortedList class
            SortedList my_slist = new SortedList();

            // Adding key/value pairs in SortedList
            // Using Add() method
            my_slist.Add(1.02, "This");
            my_slist.Add(1.07, "Is");
            my_slist.Add(1.04, "SortedList");
            my_slist.Add(1.01, "Tutorial");

            foreach(DictionaryEntry l in my_slist)
            {
                Console.WriteLine(l.Key+""+l.Value);
            }
            Console.WriteLine();
            my_slist.Remove(1.07);
            foreach (DictionaryEntry l in my_slist)
            {
                Console.WriteLine(l.Key + "" + l.Value);
            }
            Console.WriteLine("After RemoveAt() method");
            my_slist.RemoveAt(2);

            // After RemoveAt() method
            foreach (DictionaryEntry pair in my_slist)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            my_slist.Clear();
            Console.WriteLine("The total number of key/value pairs" +
                        " present in my_slist:{0}", my_slist.Count);
        }

     }
}
