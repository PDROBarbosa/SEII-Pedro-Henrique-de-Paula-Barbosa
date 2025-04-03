using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana03
{
    public class Program5
    {
        public static void Main(string[] args)
        {
            string nomeDoArquivo = "documentos.txt";

            // Lê todo o conteúdo do arquivo e armazena na variável 'conteudo'
            string conteudo = File.ReadAllText(nomeDoArquivo);

            // Imprime o conteúdo do arquivo no console
            Console.WriteLine("Conteúdo do arquivo:");
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");

            // Adiciona uma nova linha ao final do arquivo
            File.AppendAllText(nomeDoArquivo, "Um outro arquivo.");

            // Lê novamente o conteúdo do arquivo (agora com a nova linha)
            conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");

            Console.ReadKey(true);
        }
    }
}