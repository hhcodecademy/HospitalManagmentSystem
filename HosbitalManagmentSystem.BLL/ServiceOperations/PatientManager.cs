using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Enums;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class PatientManager
    {
        public static void AddPatient()
        {
            Patient patient = new Patient();
            Console.WriteLine("Xestenin adini qeyd edin: ");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Xestenin soyadini qeyd edin: ");
            patient.Surname = Console.ReadLine();
            Console.WriteLine("Xestenin cinsini daxil edin: Male-1, Female-2");
            patient.GetGenderType = (GenderType)int.Parse(Console.ReadLine());
            Console.WriteLine("Xestenin tevelludunu qeyd edin:");
            patient.DoB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Xestenin unvanini daxil edin: ");
            patient.Address = Console.ReadLine();
            Console.WriteLine("Xestenin shikayetlerini qeyd edin: ");
            string response = string.Empty;
            do
            {
                string patientComp = Console.ReadLine();
                patient.Complaints.Add(patientComp);
                Console.WriteLine("Basqa shikayet varmi?");
                response = Console.ReadLine();
            } while (response =="he");
            Console.WriteLine("Xestenin sigortasi varmi? He/Yox");
            string sorgu = Console.ReadLine();
            if (sorgu.ToLower() =="he")
            {
                patient.HasIssurance = true;
            }
            else
            {
                patient.HasIssurance = false;
            }
            DataOperation.Patients.Add(patient);
        }
        public static void ShowPatient()
        {
            foreach (var item in DataOperation.Patients )
            {
             
                Console.WriteLine($"Xestenin adi: {item.Name}, Xestenin Soyadi: {item.Surname} {item.HasIssurance}");
            }
        }
    }
}
