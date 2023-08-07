using System;

// Step 1: Define the abstract class
abstract class Shape
{
    // Step 2: Define abstract method(s) - these have no implementation in the abstract class
    public abstract double CalculateArea();

    // Step 3: Non-abstract method(s) - these have a concrete implementation
    public void Display()
    {
        Console.WriteLine($"Area: {CalculateArea()} square units");
    }
}

// Step 4: Create derived classes and implement the abstract method
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Step 5: Implement the abstract method
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Step 5: Implement the abstract method
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        // Step 6: Create objects of derived classes and use the abstract class methods
        Circle circle = new Circle(5.0);
        circle.Display(); // Output: Area: 78.53981633974483 square units

        Rectangle rectangle = new Rectangle(4.0, 6.0);
        rectangle.Display(); // Output: Area: 24 square units
    }
}
