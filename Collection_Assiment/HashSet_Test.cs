using System;
using System.Collections.Generic;

class hashset_Q1 
{

    static public void Main()
    {
        HashSet<string> myhash1 = new HashSet<string>();

        myhash1.Add("A");
        myhash1.Add("B");
        myhash1.Add("C");
        myhash1.Add("D");
        myhash1.Add("E");
        Console.WriteLine("Elements of myhash1: Total " + myhash.Count);
       
        foreach (var val in myhash1)
        {
            Console.WriteLine(val);
        }
        myhash.Remove("B");
        Console.WriteLine("Remove Element is => " + myhash.Count);
        HashSet<int> myhash2 = new HashSet<int>(){10,100,1000,10000,100000};
        Console.WriteLine("Elements of myhash2:");
        foreach (var valu in myhash2)
        {
            Console.WriteLine(valu);
        }
    }
}