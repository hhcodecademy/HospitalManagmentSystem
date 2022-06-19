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
            Console.WriteLine("Nomresini daxil edin:");
            qualification.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ixtisasinizi adin daxil edin :");
            qualification.Name = Console.ReadLine();
            Console.WriteLine("Ixtisasin aciqlamasini daxil edin :");
            qualification.Description = Console.ReadLine();
            DataOperation.Qualifications.Add(qualification);
        }
        public static int ShowQualification()
        {
            
            foreach (var item in DataOperation.Qualifications)
            {
                Console.WriteLine($"Nomre {item.Number}, ixtisasin adi {item.Name}, Ix haqqinda {item.Description}");
            }
            return DataOperation.Qualifications.Count;
        }



    }
}
