using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Controllers
{
    public class SendValueViewc : Controller
    {
        [HttpGet]
        public IActionResult GetTextBoxValue()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetTextBoxValue(string name)
        {
            return View("Display",(Object)name);
        }
    }
}
/*
 

<h1>
    Display
    hello @Model 
</h1> 
 */
