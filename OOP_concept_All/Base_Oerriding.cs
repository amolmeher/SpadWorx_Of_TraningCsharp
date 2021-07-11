using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Animal1
{
    public virtual void eatt()
    {
        Console.WriteLine("eating... Git Run");
    }
}
public class Dogg : Animal1
{
    public override void eatt()
    {
        base.eatt();
        Console.WriteLine("eating bread...");
    }

}
namespace OOP_concept_All
{
    class Base_Oerriding
    {
        public static void Main()
        {
            Dogg d = new Dogg();
            d.eatt();
        }
    }
}
