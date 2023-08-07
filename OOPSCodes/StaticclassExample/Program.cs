using System;
//A static method is a method that belongs to the class itself and not to any specific instance of the class. You can call static methods
//directly on the class name without creating an object of the class.

// Static class

//Can contain only static members (static methods, static properties, static fields, etc.).
//Cannot be instantiated, meaning you cannot create an object of a static class.
//Declared using the static keyword before the class keyword.


static class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    //Non-Static Class:
    //Can contain both static and non-static members.
    //Can be instantiated, meaning you can create objects of a non-static class.
    //Does not have the static keyword before the class keyword.

    static void Main()
    {
        int sum = MathUtils.Add(5, 10);
        Console.WriteLine("Sum: " + sum);

        int product = MathUtils.Multiply(3, 7);
        Console.WriteLine("Product: " + product);
    }
}
