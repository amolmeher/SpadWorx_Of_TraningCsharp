 using Microsoft.AspNetCore.Mvc;
using Practice_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_MVC.Controllers
{
    public class UseviewdataController : Controller
    {
        public IActionResult Index()
        {
            // Using List Show Data To Controller to view

            Student std = new Student();
            std.Sid = 10;
            std.Sname = "Amol";
            ViewData["students"] = std;
            return View();

            /*IList<Student> studentList = new List<Student>();
            Student std = new Student();
            std.Sid = 10;
            std.Sname = "Amol";
            studentList.Add(std);
            
           ViewData["students"] = std;
            return View(studentList);
            */
        }
    }
}
