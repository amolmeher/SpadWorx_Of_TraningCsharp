using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure
{
    class singlecast_delegets
    {
            public delegate void addnum(int a, int b);
            public delegate void subnum(int a, int b);

            // method "sum"
            public void sum(int a, int b)
            {
                Console.WriteLine("(100 + 40) = {0}", a + b);
            }

            // method "subtract"
            public void subtract(int a, int b)
            {
                Console.WriteLine("(100 - 60) = {0}", a - b);
            }

            // Main Method
            public static void Main(String[] args)
            {

            // creating object "obj" of class "Geeks"
            singlecast_delegets obj = new singlecast_delegets();

                addnum del_obj1 = new addnum(obj.sum);
                subnum del_obj2 = new subnum(obj.subtract);

              
                del_obj1(100, 40);
                del_obj2(100, 60);

              
            }
        }
    }

