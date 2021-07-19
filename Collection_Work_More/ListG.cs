using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Work_More
{
    class ListG
    {
        public static void Main(string[] args)
        {
           
            List<int> ls = new List<int>();
            ls.Add(00);
            ls.Add(0);
            ls.Add(1);
           ls.Add(10);
           ls.Add(100);
          ls.Add(1000);
            // Forech loop Using 
            foreach (var name in ls)
            { 
                    Console.WriteLine(name);
             }

            Console.WriteLine("Total Number Element"+ls.Count);
           // For loop Using 
           for(int i=0;i<ls.Count;i++)
            {
                Console.WriteLine("For Loop Using  " + ls[i]);
            }
            Console.WriteLine("Sorted List:");
            ls.Sort();
            
            foreach (int a in ls)
            {
                Console.WriteLine(a);
            }
        }
        
    }
}
