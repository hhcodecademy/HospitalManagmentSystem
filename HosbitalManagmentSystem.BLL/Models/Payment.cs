using HosbitalManagmentSystem.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.Models
{
    public class Payment
    {
        public string ID { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal Fee { get; set; }
        public Registration Registration { get; set; }
    }
}
