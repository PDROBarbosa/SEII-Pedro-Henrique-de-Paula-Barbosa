using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana03
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            string[] documentos = {"Documento 1.", "Documento 2."};
            string nomeDoArquivo = "documentos.txt";
            File.WriteAllLines(nomeDoArquivo, documentos);
            Console.WriteLine("O arquivo foi criado!");
            Console.ReadKey(true);
        }
    }
}