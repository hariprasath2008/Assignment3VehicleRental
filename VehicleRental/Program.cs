using System;

namespace VehicleRental
{
    public static class VehicleRental
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hi.Welcome to Vehicle Rental Management System!");

            RentalAgency agency = new RentalAgency();

            Truck truck1 = new Truck("F-150", "Ford", 2019, 130, 2000, "Pickup", true);
            Car car1 = new Car("Civic", "Honda", 2018, 83, 5, "Petrol", "Automatic", true);
            Car car2 = new Car("Challenger", "Dodge", 2022, 100, 5, "Diesel", "Manual", false);
            Motorcycle motorcycle1 = new Motorcycle("Ninja", "Kawasaki", 2018, 60, 1000, "Petrol", true);

            agency.AddVehicle(truck1);
            agency.AddVehicle(car1);
            agency.AddVehicle(car2);
            agency.AddVehicle(motorcycle1);

            Console.WriteLine("Fleet details:");
            agency.DisplayFleet();

            agency.RentVehicle(car1, 3);
            Console.WriteLine($"\n*********** Total Revenue: {agency.TotalRevenue} ***********");

            Console.WriteLine("\nFleet details after renting a car:");
            agency.DisplayFleet();
        }
    }
}
