using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scond_Web_base_Appliction.Controllers
{
    
    public class User_Controller : Controller
    {
        // GET: Home_Controller
        public ActionResult Index()
        {
            // List<UserTest> obj1 = new List<UserTest>();
            //
            //obj.Add(new User() { id = 101, str = "Amol" };
            return View();
        }
        public ViewResult Fun()
        {
            return View();
        }
        // 
        public JsonResult JasonDataUser()
        {
            string[] str = { "Amol", "Meher" };
            return Json(str);
        }
        
     
        // GET: Home_Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home_Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home_Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home_Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home_Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
