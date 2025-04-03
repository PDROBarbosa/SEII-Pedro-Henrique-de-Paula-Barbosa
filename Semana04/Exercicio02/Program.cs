using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    static void Main(string[] args)
    {
        Pessoa obj = new Pessoa();
        obj.nome = "Rodrigo";
        obj.idade = 22;
        obj.mensagem();
    }
}