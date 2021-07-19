using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assiment_7_WebApp_base.Models;

namespace Assiment_7_WebApp_base.Controllers
{
    public class EmpInfo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DAEX()
        {
            Emp_Info obj = new Emp_Info();
            return View(obj);
        }
    }
}
