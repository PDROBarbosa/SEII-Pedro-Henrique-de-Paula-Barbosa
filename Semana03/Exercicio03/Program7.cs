using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program7
    {
        public static void Main(string[] args)
        {
            string diretorio = "pasta";

            if (Directory.Exists(diretorio))
            {
                Console.WriteLine("O diretório existe");
            }
            else
            {
                Console.WriteLine("Não existe");
            }

            Console.ReadKey(true);
        }
    }
}