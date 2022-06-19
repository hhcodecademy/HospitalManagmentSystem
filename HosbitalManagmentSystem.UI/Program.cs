using HosbitalManagmentSystem.BLL.ServiceOperations;
using System;

namespace HosbitalManagmentSystem.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("1.Vəzifə əlavə et");
            Console.WriteLine("2.İxtisas əlavə et");
            Console.WriteLine("3.Doktor əlavə et");
            Console.WriteLine("4.Xidmət əlavə et ");
            Console.WriteLine("5.Analiz əlavə et ");
            Console.WriteLine("6.Xəstə əlavə et");
            Console.WriteLine("7.Doktorlari goster");
            Console.WriteLine("8.Çıxış");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    PositionManager.AddPosition();
                    menu();
                    break;
                case 2:
                    QualificationManager.AddQualification();
                    menu();
                    break;
                case 3:
                    DoctorManager.AddDoctor();
                    menu();
                    break;
                case 4:
                    ServiceManager.AddService();
                    menu();
                    break;
                case 5:
                    AnalizManager.AddAnaliz();
                    menu();
                    break;
                case 6:
                    PatientManager.AddPatient();
                    menu();
                    break;
                case 7:
                    DoctorManager.ShowDoctor();
                    menu();
                    break;
                case 8:
                    return;
                default:
                    break;
            }
        }
    }
}
