using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            string arquivo = "arquivo.txt";
            string texto = File.ReadAllText(arquivo);
            Console.WriteLine("Conteúdo do arquivo: " + texto);
            Console.ReadKey(true);
        }
    }
}