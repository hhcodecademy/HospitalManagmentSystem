using HosbitalManagmentSystem.BLL.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Patient:Person
    {
        public Patient()
        {
            ID = CustomIDGenerator.GetCurrentTimeId();
            Complaints = new List<string>();
        }

        public List<string> Complaints { get; set; }
        public bool HasIssurance { get; set; }

    }
}
