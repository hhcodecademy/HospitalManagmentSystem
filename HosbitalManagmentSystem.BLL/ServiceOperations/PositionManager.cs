using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class PositionManager
    {
        public static void AddPosition()
        {
            Position position = new Position();
            Console.WriteLine("Vezifenin adini daxil edin:");
            position.Name = Console.ReadLine();
            Console.WriteLine("Vezifenin izahini daxil edin:");
            position.Description = Console.ReadLine();
            DataOperation.Positions.Add(position);

        }
        public static void ShowPositions()
        {
            foreach (var item in DataOperation.Positions)
            {
                Console.WriteLine($"Id {item.ID}, vezifenin adi {item.Name}, vz haqqinda {item.Description}");

            }
        }

    }
}
