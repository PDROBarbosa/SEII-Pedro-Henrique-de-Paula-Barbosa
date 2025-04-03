using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program10
    {
    public static void Main(string[] args){
            string[] arquivos = Directory.GetFiles(@"C:\");

            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.ReadKey();
        }
    }
}