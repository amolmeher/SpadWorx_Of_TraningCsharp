using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Work_More
{
    class Test_SoretdMap
    {
        public static void Main(string[] args)
        {
            SortedList my_slist1 = new SortedList();
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");
            my_slist1.Add(1.01, "Tutorial");
            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
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
            // cheak Key is found or not
            if (my_slist1.Contains(1.02) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }
            // value is cheak in list
            if (my_slist1.ContainsValue("Is") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
            }
        }
    }
}
