using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assiment_7_WebApp_base.Models
{
    public class Emp_Info
    {
        [Required (ErrorMessage=" plz Only 30 char Enter")]
        public int Eid { get; set;}
        [Required(ErrorMessage = " plz Enter Name")]
        public string Empname { get; set; }

    }
}
