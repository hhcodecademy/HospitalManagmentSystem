using HosbitalManagmentSystem.BLL.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Qualification
    {
        public Qualification()
        {
            ID = CustomIDGenerator.GetCurrentTimeId();
        }
        public Int64 ID { get; }
        public int Number { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
     
    }
}
