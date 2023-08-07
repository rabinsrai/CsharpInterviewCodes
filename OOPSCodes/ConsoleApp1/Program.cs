using System;

//In C#, an interface is a contract that defines a set of methods, properties, and events without providing any implementation.
//    It only declares the members that must be implemented by the classes that implement the interface. 
//    An interface allows you to achieve multiple inheritances and enables you to define common behavior across unrelated classes.

// Step 1: Define the interface
public interface IShape
{
    // Interface methods (without implementation)
    double CalculateArea();
    double CalculatePerimeter();
}

// Step 2: Implement the interface in classes
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implement the interface methods
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implement the interface methods
    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Program
{
    public static void Main()
    {
        IShape shape1 = new Circle(5.0);
        IShape shape2 = new Rectangle(4.0, 6.0);

        // Use the interface methods
        Console.WriteLine($"Circle - Area: {shape1.CalculateArea()}, Perimeter: {shape1.CalculatePerimeter()}");
        Console.WriteLine($"Rectangle - Area: {shape2.CalculateArea()}, Perimeter: {shape2.CalculatePerimeter()}");
    }
}
