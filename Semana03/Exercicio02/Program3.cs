using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Program3
    {
        static void Main()
    {
        // Declare and initialize a dictionary
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 30 },
            { "Bob", 25 },
            { "Charlie", 35 }
        };

        // Add an item to the dictionary
        ages["David"] = 40;

        // Access value by key
        Console.WriteLine("Alice's age: " + ages["Alice"]);

        // Modify a value
        ages["Bob"] = 26;

        // Remove a key/value pair
        ages.Remove("Charlie");

        // Iterate over the dictionary
        Console.WriteLine("Names and ages in the dictionary:");
        foreach (KeyValuePair<string, int> kvp in ages)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
    }
}