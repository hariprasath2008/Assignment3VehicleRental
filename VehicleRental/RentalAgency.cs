using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RentalAgency
{
    private List<Vehicle> Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (Fleet.Contains(vehicle))
        {
            Fleet.Remove(vehicle);
            decimal rentalCost = vehicle.RentalPrice * days;
            TotalRevenue += rentalCost;
            Console.WriteLine();
            Console.WriteLine($"---->Rented {vehicle.Manufacturer} {vehicle.Model} for {days} days. Cost: ${rentalCost}");
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine(".............");
        }
    }
}
