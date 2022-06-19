using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Qualification
    {
        public Qualification()
        {
            ID = Guid.NewGuid().ToString();
        }
        public string ID { get; }
        public string Name { get; set; }
        public String Description { get; set; }
        
    }
}
