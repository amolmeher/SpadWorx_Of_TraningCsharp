using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating bread...");
    }
}
namespace OOP_concept_All
{
    class Use_Overriding
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
        } 
    }
}
