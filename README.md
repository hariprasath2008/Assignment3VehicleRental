# Vehicle Rental Management System

## Objective
The objective of this assignment is to design and implement a Vehicle Rental Management System using object-oriented principles. This system will allow you to practice inheritance, abstraction, and encapsulation while developing classes to represent various types of vehicles and a rental agency.

## Class Overview

### Vehicle Class (Vehicle.cs)
- **Properties**: 
  - `Model`
  - `Manufacturer`
  - `Year`
  - `RentalPrice`
- **Methods**:
  - `DisplayDetails()`: Displays the vehicle's details.

### Car Class (Car.cs)
- Inherits from `Vehicle`.
- **Additional Properties**:
  - `Seats`
  - `EngineType`
  - `Transmission`
  - `Convertible`
- **Methods**:
  - Overrides `DisplayDetails()` to display car-specific details.

### Truck Class (Truck.cs)
- Inherits from `Vehicle`.
- **Additional Properties**:
  - `Capacity`
  - `TruckType`
  - `FourWheelDrive`
- **Methods**:
  - Overrides `DisplayDetails()` to display truck-specific details.

### Motorcycle Class (Motorcycle.cs)
- Inherits from `Vehicle`.
- **Additional Properties**:
  - `EngineCapacity`
  - `FuelType`
  - `HasFairing`
- **Methods**:
  - Overrides `DisplayDetails()` to display motorcycle-specific details.

### RentalAgency Class (RentalAgency.cs)
- Manages the rental agency's fleet of vehicles.
- **Properties**:
  - `Fleet`: List of vehicles.
  - `TotalRevenue`: Tracks total revenue earned.
- **Methods**:
  - `AddVehicle(Vehicle vehicle)`: Adds a vehicle to the fleet.
  - `RemoveVehicle(Vehicle vehicle)`: Removes a vehicle from the fleet.
  - `RentVehicle(Vehicle vehicle, int days)`: Rents a vehicle for a specified number of days.
  - `DisplayFleet()`: Displays details of all vehicles in the fleet.

## Getting Started

### Prerequisites
- .NET SDK installed on your machine.

### Installation
1. Clone the repository.
   ```sh
   git clone https://github.com/yourusername/VehicleRentalManagementSystem.git
