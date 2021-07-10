using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Two
{
    class DataType_All
    {
        static void Main(string[] args)
        {
			int ui = 10;//4 byte	-2,147,483,648 to -2,147,483,647
			float fl = 10.2f;//4 byte	1.5 * 10-45 - 3.4 * 1038, 7-digit precision
			long l = 45755452222222l;//8 byte	?9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
			
			double d = 11452222.555d;//8 byte	5.0 * 10-324 - 1.7 * 10308, 15-digit precision
			decimal mon = 1000.15m;//16 byte	at least -7.9 * 10?28 - 7.9 * 1028, with at least 28-digit precision
			char ch = 'A';//128 to 127
			Console.WriteLine(ui);
			Console.WriteLine(fl);
			Console.WriteLine(l);
			
			Console.WriteLine(d);
			Console.WriteLine(mon);
			Console.WriteLine(ch);



			//
			Console.WriteLine("sizeof(int): {0}", sizeof(int));
			Console.WriteLine("sizeof(float): {0}", sizeof(float));
			Console.WriteLine("sizeof(char): {0}", sizeof(char));
			Console.WriteLine("sizeof(double): {0}", sizeof(double));
			Console.WriteLine("sizeof(bool): {0}", sizeof(bool));

			//hit ENTER to exit the program
			Console.ReadLine();
		}
    }
}
/*
 * 
 * 
 * 
 * 
 * 
 */