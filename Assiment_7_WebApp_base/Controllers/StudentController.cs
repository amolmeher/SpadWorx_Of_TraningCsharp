using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Models.Student st = new Models.Student();
            st.id = 10;
            st.name = "Amol";
            ViewBag.StudentObj = st;
            return View();
        }
    }
}
