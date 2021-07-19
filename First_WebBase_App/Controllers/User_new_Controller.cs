using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_WebBase_App.Controllers
{
    public class User_new_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
