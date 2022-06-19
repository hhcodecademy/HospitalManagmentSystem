using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Position
    {
        public string ID { get;  }
        public string Name { get; set; }
        public String Description { get; set; }
        public Position()
        {
            ID = Guid.NewGuid().ToString();
        }

    }
}
