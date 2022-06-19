using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Patient:Person
    {
        public Patient()
        {
            ID = Guid.NewGuid().ToString();
            Complaints = new List<string>();
        }

        public List<string> Complaints { get; set; }
        public bool HasIssurance { get; set; }

    }
}
