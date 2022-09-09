using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        //Comes from IVehicle
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 4;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Pilot";
        //Comes from ICompany
        public string CompanyName { get; set; } = "Apple Honda";
        public bool OpenWeekends { get; set; } = true;


        public string CargoSpace { get; set; } = "64 Cubic Ft";
        public bool ThirdRow { get; set; } = true;
    }
}
