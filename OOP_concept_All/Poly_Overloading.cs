using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concept_All
{
    class Poly_Overloading
    {
        public static void Mian(string[] args)
        {
            Poly p = new Poly();
          int x=p.show(10, 20);
            Console.WriteLine(x);
            p.show(10, 20.4f);

        }
    }
}
class Poly
{
    public int show(int a,int b)
    {

       return a + b;
    }
    public void show(int a,float b)
    {
       Console.WriteLine(a + b);
       
    }
}