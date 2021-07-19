using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Models
{
    public class Emp
    {
       public  int Emp_id;
       public string Emp_name;
       public  string Gender;

        public int Emp_id1 { get => Emp_id; set => Emp_id = value; }
        public string Emp_name1 { get => Emp_name; set => Emp_name = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
    }
}
