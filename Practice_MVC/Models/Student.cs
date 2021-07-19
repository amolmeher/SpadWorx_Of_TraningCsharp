using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_MVC.Models
{
    public class Student
    {
        private string sname;
        private int sid;

        public string Sname { get => sname; set => sname = value; }
        public int Sid { get => sid; set => sid = value; }
    }
}
