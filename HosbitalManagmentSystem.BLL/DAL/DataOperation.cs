using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.DAL
{
    public class DataOperation
    {
        public static List<Analays> Analayses { get; set; }
        public static List<Service> Services { get; set; }
        public static List<Position> Positions { get; set; }
        public static List<Doctor> Doctors { get; set; }
        public static List<Qualification> Qualifications { get; set; }
        public static List<Patient> Patients { get; set; }
        static DataOperation()
        {

            Doctors = new List<Doctor>();
            Qualifications = new List<Qualification>();
            Positions = new List<Position>();
            Services = new List<Service>();
            Analayses = new List<Analays>();
            Patients = new List<Patient>();
        }
    }
}
