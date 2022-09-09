using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Truck truck1 = new Truck();
            SUV suv1 = new SUV();

            var vehicles = new List<IVehicle>() { car1, truck1, suv1};
            
            foreach (var vehicle in vehicles)
            {
                if(vehicle is Car)
                {
                    Console.WriteLine($"Make: {car1.Make}");
                    Console.WriteLine($"Model: {car1.Model}");
                    Console.WriteLine($"Number of wheels: {car1.NumberOfWheels}");
                    Console.WriteLine($"Number of seats: {car1.NumberOfSeats}");
                    Console.WriteLine(value: $"Does it have a trunk: {car1.HasTrunk}");
                    Console.WriteLine(value: $"Is is a coupe: {car1.IsItACoupe}");
                    Console.WriteLine($"Comapny bought at: {car1.CompanyName}");
                    Console.WriteLine($"Are they open on weekends: {car1.OpenWeekends}");
                    Console.WriteLine("---------------------------------------------------");
                }
                if(vehicle is Truck)
                {
                    Console.WriteLine($"Make: {truck1.Make}");
                    Console.WriteLine($"Model: {truck1.Model}");
                    Console.WriteLine($"Number of wheels: {truck1.NumberOfWheels}");
                    Console.WriteLine($"Number of seats: {truck1.NumberOfSeats}");
                    Console.WriteLine(value: $"Does it have a bed: {truck1.HasABed}");
                    Console.WriteLine(value: $"Engine size: {truck1.EngineSize}");
                    Console.WriteLine($"Comapny bought at: {truck1.CompanyName}");
                    Console.WriteLine($"Are they open on weekends: {truck1.OpenWeekends}");
                    Console.WriteLine("---------------------------------------------------");
                }
                if(vehicle is SUV)
                {
                    Console.WriteLine($"Make: {suv1.Make}");
                    Console.WriteLine($"Model: {suv1.Model}");
                    Console.WriteLine($"Number of wheels: {suv1.NumberOfWheels}");
                    Console.WriteLine($"Number of seats: {suv1.NumberOfSeats}");
                    Console.WriteLine(value: $"Cargo space: {suv1.CargoSpace}");
                    Console.WriteLine(value: $"Does it have third row: {suv1.ThirdRow}");
                    Console.WriteLine($"Comapny bought at: {suv1.CompanyName}");
                    Console.WriteLine($"Are they open on weekends: {suv1.OpenWeekends}");
                    Console.WriteLine("---------------------------------------------------");
                }
            }
        }
    }
}
