using System;
using System.Collections;
class GFG
{
    static public void Main()
    {

        SortedList my_slist = new SortedList()
        {
                             { "b.09", 234 },
                             { "b.11", 395 },
                             { "b.01", 405 },
                             { "b.67", 100 },
                             { "b.55", 500 }
        };

        foreach (DictionaryEntry pair in my_slist)
        {
            Console.WriteLine("{0} and {1}", pair.Key, pair.Value);
        }
    }
}
Output: