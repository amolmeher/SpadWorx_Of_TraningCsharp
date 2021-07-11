using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Shap
{
    public virtual void draw()
    {
        Console.WriteLine("shap method drawing...");
    }
}
public class Rectangle : Shap
{
    public override void draw()
    {
        Console.WriteLine("drawing  rectangle class Run ...");
    }
}
public class Circle : Shap
{
    public override void draw()
    {
        Console.WriteLine("drawing  circle class Run...");
    }

}


namespace OOP_concept_All
{
    class Poly_morphism
    {
        public static void Main()
        {
            Shap s;
            s = new Shap();
            s.draw();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
        }
}
