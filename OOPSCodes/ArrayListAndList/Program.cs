//ArrayList is a non - generic collection class that can hold elements of any data type. It's part of the System.Collections namespace.
using System;
using System.Collections;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList(); // Create an ArrayList

        // Step 1: Add elements to the ArrayList
        arrayList.Add("Hello");
        arrayList.Add(42);
        arrayList.Add(3.14);

        // Step 2: Access elements using indexing
        Console.WriteLine(arrayList[0]); // Output: Hello

        // Step 3: Iterate through the ArrayList
        foreach (object item in arrayList)
        {
            Console.WriteLine(item);
        }

        //List<T> is a generic collection class that provides type safety and better performance compared to ArrayList.
        //It's part of the System.Collections.Generic namespace.

        //Choose List<T> when you know the specific type of elements you'll be working with, and choose ArrayList 
        //    when you need to work with a heterogeneous collection.

        List<int> intList = new List<int>(); // Create a List<int>

        // Step 1: Add elements to the List
        intList.Add(5);
        intList.Add(10);
        intList.Add(15);

        // Step 2: Access elements using indexing
        Console.WriteLine(intList[0]); // Output: 5

        // Step 3: Iterate through the List
        foreach (int num in intList)
        {
            Console.WriteLine(num);
        }

    }
}
