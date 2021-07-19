using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Controllers
{
    public class VCDParamerType : Controller
    {
        // pass Data View to Controller Using Parameter
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       /* [HttpPost]
        public string postUsingParameter(string fname,string lname)
        {
            return "from para"+fname+" "+lname;
        }*/
        /*Pass Data Using REqusest
        [HttpPost]
        public string PostUsingRequest()
        {

            string fname = Request["fname"];
            string lname = Request["fname"];
            return fname+"  "+lname;
        }*/

        //Pass Data Using FormCollection
        [HttpPost]
        public string PostFormCollectionx(FormCollection form)
        {

            string fname = form["fname"];
            string lname = form["lname"];
            return " info is  =>  "+fname+"  "+lname;
        }




    }
}
