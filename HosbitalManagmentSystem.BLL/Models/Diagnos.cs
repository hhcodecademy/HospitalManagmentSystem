using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Diagnos
    {
        public Int64 ID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string DiagnosResult { get; set; }

    }
}
