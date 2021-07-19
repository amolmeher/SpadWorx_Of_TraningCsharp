using Assiment_7_WebApp_base.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Dt = DateTime.Now.ToString("MM/yy HH:mm:ss");

            return View();
        }
        public ViewResult ViewResultEx()
        {
            return View();
        }
        public JsonResult jsonResultEx()
        {
            string[] fruit = { "Apple", "Mango" };
            return Json(fruit);
        }
        public FileContentResult fileContentEx()
        {
            var pdf = System.IO.File.ReadAllBytes("wwwroot/Amol_Final.pdf");
            return new FileContentResult(pdf, "application/pdf");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
