using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Three
{
    class Array_BasicTry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array");
            int size= Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
           
            int[] arr = new int[size];
            Console.WriteLine("Entre the Array Element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
               Console.WriteLine(arr[i]);
            }
        }
    }
}
