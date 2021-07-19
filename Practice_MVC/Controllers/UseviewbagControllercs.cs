using Microsoft.AspNetCore.Mvc;
using Practice_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_MVC.Controllers
{
    public class UseviewbagControllercs : Controller
    {
        public IActionResult Index()
        {
            Student std = new Student();
            std.Sid = 10;
            std.Sname = "Amol";
            ViewBag.obj=std;
            return View();
           
        }
    }
}
