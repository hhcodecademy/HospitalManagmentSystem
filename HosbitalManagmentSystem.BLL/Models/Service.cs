using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
   public class Service
    {
        public Service() 
        {
            ID = Guid.NewGuid().ToString();
        }

        public string ID { get;  }
        public string Name { get; set; }
        public String Description { get; set; }
    }
}
