using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assiment_7_WebApp_base.Models;

namespace Assiment_7_WebApp_base.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Emp emp = new Emp();
            List<Emp> list = new List<Emp>();
            emp.Emp_id = 10;
            emp.Emp_name = "Siddi";
            emp.Gender = "female";
            list.Add(emp);



            return View(list);
        }
    }
}
