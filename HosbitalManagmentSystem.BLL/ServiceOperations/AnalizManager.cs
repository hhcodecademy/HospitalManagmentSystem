using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
   public class AnalizManager
    {
        public static void AddAnaliz()
        {
            Analays analiz = new Analays();
            Console.WriteLine("Analizin adini daxil edin: ");
            analiz.Name = Console.ReadLine();
            Console.WriteLine("Analizin izahini daxil edin: ");
            analiz.Description = Console.ReadLine();
            DataOperation.Analayses.Add(analiz);
        }
        public static void ShowAnaliz()
        {
            foreach (var item in DataOperation.Analayses )
            {
                Console.WriteLine($"Id: {item.ID}, Analizin adi: {item.Name}, Analiz haqqinda: {item.Description}");
            }
        }

    }
}
