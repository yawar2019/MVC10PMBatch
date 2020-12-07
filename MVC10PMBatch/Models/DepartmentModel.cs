using MVC10PMBatch.Filter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC10PMBatch.Models
{
    public class DepartmentModel
    {
        [Required]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}