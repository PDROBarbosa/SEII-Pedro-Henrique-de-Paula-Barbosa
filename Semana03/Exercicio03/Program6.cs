using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program6
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "arquivo.txt";

            Console.WriteLine(File.Exists(nomeDoArquivo));

            File.WriteAllText(nomeDoArquivo, "Algum texto");

            Console.WriteLine(File.Exists(nomeDoArquivo));

            Console.ReadKey(true);
        }
    }
}