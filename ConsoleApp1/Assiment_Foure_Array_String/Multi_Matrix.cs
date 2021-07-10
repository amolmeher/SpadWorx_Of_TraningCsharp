using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class Multi_Matrix
    {
        static void Main()
        {

            int m, n, i, j;

            Console.Write("Enter number of rows and columns of the matrix ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());

            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int[,] arr3 = new int[10, 10];

            Console.Write("Enter elements - Matrix 1 : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Write("Enter elements - Matrix 2 : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix 1 ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix 2 ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] * arr2[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix Addition ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
