using HosbitalManagmentSystem.BLL.DAL;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class PositionManager
    {
        public static readonly string path = @"C:\Users\elvinti\Desktop\DataStorage\positions.txt";
        public static void ChooseStorage()
        {
            Console.WriteLine("Yazmaq istediyinz yeri seciniz: (List:1,File:2,FromFile:3)");
            int choosedStorage = int.Parse(Console.ReadLine());
            switch (choosedStorage)
            {
                case 1:
                    AddPositionToList();
                    break;
                case 2:
                    AddPositionToFile();
                    break;
                case 3:
                    WriteDataToConsole();
                    break;
                default:
                    break;
            }
        }
        public static void AddPositionToList()
        {
            Position position = new Position();
            Console.WriteLine("Nomresini daxil edin:");
            position.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Vezifenin adini daxil edin:");
            position.Name = Console.ReadLine();
            Console.WriteLine("Vezifenin izahini daxil edin:");
            position.Description = Console.ReadLine();
            DataOperation.Positions.Add(position);

            Console.WriteLine(position.ToString());

        }
        public static void ShowPositions()
        {
            foreach (var item in DataOperation.Positions)
            {
                Console.WriteLine($"Nomre {item.Number}, ixtisasin adi {item.Name}, Ix haqqinda {item.Description}");

            }
        }

        public static void AddPositionToFile()
        {
            Position position = new Position();
            Console.WriteLine("Nomresini daxil edin:");
            position.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Vezifenin adini daxil edin:");
            position.Name = Console.ReadLine();
            Console.WriteLine("Vezifenin izahini daxil edin:");
            position.Description = Console.ReadLine();
            DataOperation.Positions.Add(position);




            List<string> list = new List<string>();
            list.Add(position.ToString());

            File.AppendAllLines(path, list);
        }
        public static List<Position> GetDataFromFile()
        {
            //Number: 1;ID: 20220625182453846;Name: Mduur;Description: hhb
            List<Position> positions = new List<Position>();
            try
            {
                Dictionary<string, string> dicProp = new Dictionary<string, string>();
                string[] records = File.ReadAllLines(path);
                foreach (var item in records)
                {
                    string[] properties = item.Split(";");

                    Position position = new Position();
                    position.Number = int.Parse(properties[0]);
                    position.Name = properties[2];
                    position.Description = properties[3];
                    positions.Add(position);

                }
              
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           


            return positions;
        }

        public static void WriteDataToConsole()
        {

            foreach (var item in GetDataFromFile())
            {
                Console.WriteLine(item.ToString());
            }
        }
        }

    }
}
