using System;
using System.Collections.Generic;

class Dis_Test
{

    static public void Main()
    {
        Dictionary<int, string> d1 = new Dictionary<int, string>();
        d1.Add(1123, "Welcome");
        d1.Add(1124, "to");
        d1.Add(1125, "GeeksforGeeks");
        foreach (KeyValuePair<int, string> ele1 in d1)
        {
            Console.WriteLine(ele1.Key, ele1.Value);
        }
        Dictionary<string, string> My_dict2 =
             new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "cow"} };

        foreach (KeyValuePair<string, string> ele2 in My_dict2)
        {
            Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
        }
        // cheak Key And Value
        if (My_dict.ContainsKey(1122) == true)
        {
            Console.WriteLine("Key is found...!!");
        }

        else
        {
            Console.WriteLine("Key is not found...!!");
        }

        // Using ContainsValue() method to check
        // the specified value is present or not
        if (My_dict.ContainsValue("GeeksforGeeks") == true)
        {
            Console.WriteLine("Value is found...!!");
        }

        else
        {
            Console.WriteLine("Value is not found...!!");
        }
    }
}