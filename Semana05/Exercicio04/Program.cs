using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Program
    {

    static void Main(string[] args)
    {
    }
        

    static async Task<string> SummonDogLocally()
        {
        Console.WriteLine("1. Summoning Dog Locally...");

        // Lê todo o texto dentro do arquivo dog.txt de forma assíncrona
        string dogText = await File.ReadAllTextAsync("dog.txt");

        // Exibe os dados do arquivo de texto
        Console.WriteLine($"2. Dog Summoned Locally \n{dogText}");

        return dogText;
        }

    static async Task<string> SummonDogFromURL(string URL)
    {
        Console.WriteLine("1. Summoning Dog from URL...");

        using (var httpClient = new HttpClient())
        {
            string result = await httpClient.GetStringAsync(URL);

            // From this line and below, the execution will resume once the
            // above awaitable is done
            // using await keyword, it will do the magic of unwrapping
            // the Task<string> into string (result variable)

            Console.WriteLine($"2. Dog Summoned from URL \n{result}");
        }
        return result;
    }
    }
}