using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Three_Webbase_Appliction.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
           // ViewBag.Message=_look.GetWe
            return View();
        }
    }
}
