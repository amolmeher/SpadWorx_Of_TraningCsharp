using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection_Work_More
{
    class Employee
    {
        int id;
        string name;
        string loction;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Loction { get => loction; set => loction = value; }
    }
    class Emp_Main
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            
           
            ArrayList list= new ArrayList();
            list.Add(e.Id=10);
            list.Add(e.Name = "Amol");
            list.Add(e.Loction = "Pune");
            foreach (var item in list)
            {
                string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(arrayItem);
            }
        }
    }
}

