using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program4
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";
            string[] documentos = File.ReadAllLines(nomeDoArquivo);

            foreach (string documento in documentos)
                Console.WriteLine(documento);

            Console.ReadKey(true);
        }
    }
}