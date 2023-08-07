using System;

// Common base class for vehicles
class Vehicle
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string model, int year)
    {
        Model = model;
        Year = year;
    }
}

// Interface for calculating maintenance price
interface IMaintenanceCalculator
{
    double CalculateMaintenancePrice();
}

// Class for Two-Wheeler
class TwoWheeler : Vehicle, IMaintenanceCalculator
{
    public int EngineCC { get; set; }

    public TwoWheeler(string model, int year, int engineCC) : base(model, year)
    {
        EngineCC = engineCC;
    }

    public double CalculateMaintenancePrice()
    {
        return EngineCC * 0.1;
    }
}

// Class for Four-Wheeler
class FourWheeler : Vehicle, IMaintenanceCalculator
{
    public int SeatingCapacity { get; set; }

    public FourWheeler(string model, int year, int seatingCapacity) : base(model, year)
    {
        SeatingCapacity = seatingCapacity;
    }

    public double CalculateMaintenancePrice()
    {
        return SeatingCapacity * 50;
    }
}

class Program
{
    static void Main()
    {
        TwoWheeler bike = new TwoWheeler("Honda CB", 2022, 150);
        FourWheeler car = new FourWheeler("Toyota Camry", 2020, 5);

        double bikeMaintenancePrice = bike.CalculateMaintenancePrice();
        double carMaintenancePrice = car.CalculateMaintenancePrice();

        Console.WriteLine($"Two-Wheeler: {bike.Model} ({bike.Year})");
        Console.WriteLine($"Maintenance Price: {bikeMaintenancePrice:C}");

        Console.WriteLine();

        Console.WriteLine($"Four-Wheeler: {car.Model} ({car.Year})");
        Console.WriteLine($"Maintenance Price: {carMaintenancePrice:C}");
    }
}
