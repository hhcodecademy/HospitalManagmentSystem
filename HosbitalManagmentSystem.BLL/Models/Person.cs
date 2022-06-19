using HosbitalManagmentSystem.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public abstract class Person
    {
        
        protected string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public GenderType GetGenderType { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
    }
}
