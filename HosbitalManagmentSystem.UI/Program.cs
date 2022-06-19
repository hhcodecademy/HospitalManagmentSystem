using HosbitalManagmentSystem.BLL.ServiceOperations;
using System;

namespace HosbitalManagmentSystem.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientManager.ShowPatient();
            for (int i = 0; i < 2; i++)
            {
                PatientManager.AddPatient();
            }
            PatientManager.ShowPatient();

            //AnalizManager.ShowAnaliz();
            //for (int i = 0; i < 2; i++)
            //{
            //    AnalizManager.AddAnaliz();

            //}
            //AnalizManager.ShowAnaliz();

            //ServiceManager.ShowService();
            //for (int i = 0; i < 3; i++)
            //{
            //    ServiceManager.AddService();
            //}
            //ServiceManager.ShowService();


            //PositionManager.ShowPositions();
            //for (int i = 0; i < 3; i++)
            //{
            //    PositionManager.AddPosition();
            //}
            //PositionManager.ShowPositions();
            //QualificationManager.ShowQualification();
            //for (int i = 0; i < 3; i++)
            //{
            //    QualificationManager.AddQualification();
            //}
            //QualificationManager.ShowQualification();

            //for (int i = 0; i < 3; i++)
            //{
            //    DoctorManager.AddDoctor();
            //}
            //DoctorManager.ShowDoctor();


        }
    }
}
