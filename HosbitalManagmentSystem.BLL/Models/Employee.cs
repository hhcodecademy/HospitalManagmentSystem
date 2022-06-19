using HosbitalManagmentSystem.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Employee : Person
    {
        public EmployeeType EmployeeType { get; set; }
        public decimal Salary { get; set; }

    }
}
