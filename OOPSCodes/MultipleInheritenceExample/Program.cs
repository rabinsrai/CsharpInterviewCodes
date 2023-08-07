
//C# supports multiple inheritance through interfaces. Unlike some other programming languages, 
//    C# does not support multiple inheritance of classes (i.e., inheriting from multiple base classes).
//    However, you can achieve similar behavior by implementing multiple interfaces in a single class.

using System;

// Define multiple interfaces
interface IShape
{
    double CalculateArea();
}

interface IDrawable
{
    void Draw();
}

// Implement the interfaces in a single class
class Circle : IShape, IDrawable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5.0);

        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        circle.Draw();
    }
}
