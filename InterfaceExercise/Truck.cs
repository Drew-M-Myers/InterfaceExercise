using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        //Comes from IVehicle
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 2;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-150";
        //Comes from ICompany
        public string CompanyName { get; set; } = "Genlatta Ford";
        public bool OpenWeekends { get; set; } = true;


        public bool HasABed { get; set; } = true;
        public string EngineSize { get; set; } = "V6";
    }
}
