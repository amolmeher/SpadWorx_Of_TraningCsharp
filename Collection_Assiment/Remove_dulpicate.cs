using System;
using System.Collections.Generic;

class GFG
{
   static public void Main()
    {

        HashSet<string> myhash1 = new HashSet<string>();
        myhash1.Add("C");
        myhash1.Add("C++");
        myhash1.Add("C#");
        myhash1.Add("Java");
        myhash1.Add("Ruby");

        HashSet<string> myhash2 = new HashSet<string>();
        myhash2.Add("PHP");
        myhash2.Add("C++");
        myhash2.Add("Perl");
        myhash2.Add("Java");

        // Using UnionWith method
        myhash1.UnionWith(myhash2);
        foreach (var ele in myhash1)
        {
            Console.WriteLine(ele);
        }
        //  Using IntersectWith method
        myhash1.IntersectWith(myhash2);
        foreach (var ele in myhash1)
        {
            Console.WriteLine(ele);
        }
        // Using ExceptWith method
        myhash1.ExceptWith(myhash2);
        foreach (var ele in myhash1)
        {
            Console.WriteLine(ele);
        }
    }
}