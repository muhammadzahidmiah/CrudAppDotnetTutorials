﻿using System.ComponentModel.DataAnnotations;

namespace CrudAppDotnetTutorials.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        [Display(Name = "Department Name")]
        public string DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}