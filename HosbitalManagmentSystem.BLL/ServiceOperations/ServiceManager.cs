using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class ServiceManager
    {
        public static void AddService()
        {
            Service service = new Service();
            Console.WriteLine("Xidmetin adini daxil edin: ");
            service.Name = Console.ReadLine();
            Console.WriteLine("Xidmetin izahini daxil edin");
            service.Description = Console.ReadLine();

            DataOperation.Services.Add(service);
        }
        public static void ShowService()
        {
            foreach (var item in DataOperation.Services)
            {
                Console.WriteLine($"Id {item.ID}, Servisin adi {item.Name}, Servis haqqinda {item.Description}");
            }
        
        }
       


    }
}
