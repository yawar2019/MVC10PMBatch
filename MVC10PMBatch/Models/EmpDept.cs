﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC10PMBatch.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> Emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}