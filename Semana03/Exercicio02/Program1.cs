// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Program1
{
    static void Main()
    {
        // Declare and initialize an array
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

        
        // Access elements by index
        Console.WriteLine("First number: " + numbers[0]);

        // Modify an element
        numbers[2] = 10;

        // Iterate over the array
        Console.WriteLine("Numbers in the array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
