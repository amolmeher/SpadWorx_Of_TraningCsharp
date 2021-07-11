using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concept_All
{
    class method_overrinding
    {
        static void Main(string[] agrs)
        {
            icici ic = new icici();
            ic.ROI();
           

            icici icc = new icici();
            icc.ROI();
           // icici icbk = new Bank();

        }
    }
}
class Bank
{
    public  virtual float ROI()
    {
        Console.WriteLine("im bank methid");
        return 4.5f;
    }
}
class icici : Bank
{
    public float ROI()
    {
        
        float ri = 4.5f;
     
        Console.WriteLine("im icic method");
        return 4.5f;

    }
}
