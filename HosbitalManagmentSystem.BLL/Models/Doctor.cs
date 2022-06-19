using HosbitalManagmentSystem.BLL.Enums;
using HosbitalManagmentSystem.BLL.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Doctor:Person  
    {
        public Doctor() {
            ID = CustomIDGenerator.GetCurrentTimeId();
            Qualifications = new List<Qualification>();
        }
        public decimal  Salary  { get; set; }
        public ContractType ContractType { get; set; }

        public List<Position> Positions { get; set; }

        public List<Qualification> Qualifications { get; set; }


    }
}
