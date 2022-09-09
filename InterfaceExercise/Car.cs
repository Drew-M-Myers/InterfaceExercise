using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        //Comes from IVehicle
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 4;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";
        //Comes from ICompany
        public string CompanyName { get; set; } = "Hanover Toyota";
        public bool OpenWeekends { get; set; } = false;


        public bool HasTrunk { get; set; } = true;
        public bool IsItACoupe = true;
    }
}
