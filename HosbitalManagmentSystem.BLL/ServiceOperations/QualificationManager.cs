using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class QualificationManager
    {
        
        public static void AddQualification()
        {
            Qualification qualification = new Qualification();
            Console.WriteLine("Ixtisasinizi adin daxil edin :");
            qualification.Name = Console.ReadLine();
            Console.WriteLine("Ixtisasin aciqlamasini daxil edin :");
            qualification.Description = Console.ReadLine();
            DataOperation.Qualifications.Add(qualification);
        }
        public static void ShowQualification()
        {
            foreach (var item in DataOperation.Qualifications)
            {
                Console.WriteLine($"Id {item.ID}, ixtisasin adi {item.Name}, Ix haqqinda {item.Description}");
            }
        }



    }
}
