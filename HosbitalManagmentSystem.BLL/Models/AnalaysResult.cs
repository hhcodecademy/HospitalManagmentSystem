using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class AnalaysResult
    {
        public string ID { get; set; }
        public Survey Survey { get; set; }
        public Analays Analays { get; set; }
        public string Result { get; set; }
    }
}
