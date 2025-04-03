using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Program8
    {
        public static void Main(string[] args)
        {
            string pasta = "Nova pasta";
            Directory.CreateDirectory(pasta);
            Console.ReadKey(true);
        }
    }
}