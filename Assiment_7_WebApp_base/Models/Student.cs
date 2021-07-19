using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Models
{
    public class Student
    {
        public int id;
       public string name ;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
