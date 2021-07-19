using System;
using System.Collections.Generic;
using System.Collections;
namespace Collection_Assiment
{
    class SOrtedList_Exam1
    {
        static public void Main()
        {
            SortedList list = new SortedList();
            list.Add(1.02, "This");
            list.Add(1.07, "Is");
           list.Add(1.04, "SortedList");
            list.Add(1.01, "Tutorial");
            foreach(DictionaryEntry p in list)
            {
                Console.WriteLine(p.Key + "     "+p.Value);
            }
            Console.WriteLine();
            SortedList my_slist2 = new SortedList()
            {
                                  { "b.09", 234 },
                                  { "b.11", 395 },
                                  { "b.01", 405 },
                                  { "b.67", 100 }
            };

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
        }
     }
}
