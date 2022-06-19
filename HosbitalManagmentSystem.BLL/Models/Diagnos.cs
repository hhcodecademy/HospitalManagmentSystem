using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Diagnos
    {
        public string ID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string DiagnosResult { get; set; }

    }
}
