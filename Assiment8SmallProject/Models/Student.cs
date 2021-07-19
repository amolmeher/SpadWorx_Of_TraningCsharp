using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Assiment8SmallProject.Models
{
    public class Student
    {
        private string name;
        private string address;
        private string gender;
        private string email;
        private int rollNo;
        private int mobileNo;
        private string course;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name = "Student Name")]
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get => email; set => email = value; }
        public int RollNo { get => rollNo; set => rollNo = value; }
        [Required(ErrorMessage = "Please enter Mobile No")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public int MobileNo { get => mobileNo; set => mobileNo = value; }
        public string Course { get => course; set => course = value; }
    }
}
