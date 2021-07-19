using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assiment
{
    class List_Genaric
    {
        public static void Main(string[] args)
        {
            List<int> my_list = new List<int>();
            my_list.Add(1);
            my_list.Add(10);
            my_list.Add(100);
            my_list.Add(1000);
            my_list.Add(10000);
            my_list.Add(100000);
            my_list.Add(1000000);
            my_list.Add(10000000);
            my_list.Add(100000000);
            Console.WriteLine("MyList Count   " + my_list.Count);
            my_list.Remove(10);
            my_list.RemoveAt(3);

            foreach (int a in my_list)
            {
                Console.WriteLine(a);
            }


        }
    }
}
