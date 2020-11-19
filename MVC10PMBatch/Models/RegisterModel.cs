using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC10PMBatch.Models
{
    public class RegisterModel
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Employee Name Cannot be Empty")]
        public string EmpName { get; set; }
        [Range(25,50,ErrorMessage ="Age Should be between 25-50")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Pwd and Cpwd is Not Matching")]
        public string ConfirmPwd { get; set; }
        [Required(ErrorMessage = "EmailId Cannot be Empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid EmailId")]
        public string EmailId { get; set; }
        [StringLength(20,ErrorMessage ="Only 20 Characters Allowed")]
        public string Address { get; set; }

    }
}