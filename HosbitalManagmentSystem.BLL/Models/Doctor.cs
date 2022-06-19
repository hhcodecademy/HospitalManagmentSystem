using HosbitalManagmentSystem.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Doctor:Person  
    {
        public Doctor() {
            ID = Guid.NewGuid().ToString();
        }
        public decimal  Salary  { get; set; }
        public ContractType ContractType { get; set; }

        public List<Position> Positions { get; set; }

        public List<Qualification> Qualifications { get; set; }


    }
}
