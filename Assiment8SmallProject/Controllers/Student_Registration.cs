using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment8SmallProject.Controllers
{
    public class Student_Registration : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string getparam1(string fname,string Add ,
            string Gender,string email,int rno, int mno,string course)
        {
            
            return "\t" + fname+"\n"+Add+""+ Gender+" "+email+" "+rno+" "+rno+" "+mno+" "+course;
        }
    }
}
