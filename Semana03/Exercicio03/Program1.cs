using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana03.Exercicio03
{
    public class Program1
    {
        public static void Main(string[] args){
            string nomeDoArquivo = "arquivo.txt";
            string texto = "Este é um documento de texto.";
            File.WriteAllText(nomeDoArquivo, texto);
            Console.WriteLine("Arquivo criado com sucesso!");
            Console.ReadKey(true);
            }
    }
}