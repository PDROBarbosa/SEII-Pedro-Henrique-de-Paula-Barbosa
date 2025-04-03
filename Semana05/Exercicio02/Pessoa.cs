using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int v;

        public Pessoa(string nome, string sobrenome, int v)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.v = v;
        }
    }
}