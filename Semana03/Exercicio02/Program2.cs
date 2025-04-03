using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Program2
    {
        static void Main()
    {
        // Declare and initialize a list
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        // Add an item to the list
        fruits.Add("Date");

        // Access elements by index
        Console.WriteLine("First fruit: " + fruits[0]);

        // Modify an element
        fruits[1] = "Blueberry";

        // Remove an element
        fruits.Remove("Apple");

        // Iterate over the list
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
    }
}