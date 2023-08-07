using System;

// Abstract base class
abstract class Wheeler
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Wheeler(string model, int year)
    {
        Model = model;
        Year = year;
    }

    // Abstract method to calculate maintenance price
    public abstract double CalculateMaintenancePrice();
}

// Derived class: TwoWheeler
class TwoWheeler : Wheeler
{
    public int EngineCC { get; set; }

    public TwoWheeler(string model, int year, int engineCC) : base(model, year)
    {
        EngineCC = engineCC;
    }

    // Implement abstract method to calculate maintenance price
    public override double CalculateMaintenancePrice()
    {
        // Calculate maintenance price for two-wheeler (example calculation)
        return EngineCC * 0.1;
    }
}

// Derived class: FourWheeler
class FourWheeler : Wheeler
{
    public int SeatingCapacity { get; set; }

    public FourWheeler(string model, int year, int seatingCapacity) : base(model, year)
    {
        SeatingCapacity = seatingCapacity;
    }

    // Implement abstract method to calculate maintenance price
    public override double CalculateMaintenancePrice()
    {
        // Calculate maintenance price for four-wheeler (example calculation)
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
