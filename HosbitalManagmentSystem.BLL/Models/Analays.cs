using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Analays
    {
        public Analays()
        {
            ID = Guid.NewGuid().ToString();
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
