﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Survey
    {
        public string ID { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public string Description { get; set; }
    }
}
