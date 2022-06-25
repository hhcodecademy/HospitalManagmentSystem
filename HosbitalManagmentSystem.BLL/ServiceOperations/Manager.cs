using HosbitalManagmentSystem.BLL.Enums;
using HosbitalManagmentSystem.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HosbitalManagmentSystem.BLL.ServiceOperations
{
    public class Manager<T>
    {
        public static void serviceCall()
        {

            Type doctor = typeof(Doctor);
            if (typeof(T) == doctor)
            {

                DoctorManager.AddDoctor();


            }

            Type qualification = typeof(Qualification);
            if (typeof(T) == qualification)
            {
                QualificationManager.AddQualification();
            }
            Type position = typeof(Position);
            if (typeof(T) == position)
            {
                PositionManager.ChooseStorage();



            }
        }
    }
}
