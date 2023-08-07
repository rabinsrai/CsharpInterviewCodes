using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class inheriting from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat(); // Inherited from the base class
        dog.Bark();
    }
}
