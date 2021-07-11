using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concept_All
{
    class Emp
    {
        private int id;
        private string name;
        private float sal;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Salery { get => sal; set => sal = value; }
    }
    class GetEmp
    {
        public void getData()
        {
            Emp e = new Emp();
            Console.WriteLine("Enter RollNo");
            e.Id= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            e.Name = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            e.Salery = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Employee ID: " + e.Id);
            Console.WriteLine("Employee Name: " + e.Name);
            Console.WriteLine("Employee Salary: " + e.Salery);


        }
    }
    class Get_Set
    {
        static void Main()
        {
            GetEmp empobj = new GetEmp();
            empobj.getData();
        }

    }
}
