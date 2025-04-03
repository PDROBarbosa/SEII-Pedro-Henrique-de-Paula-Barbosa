using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Program
    {

    static void Main(string[] args)
    {
    Stopwatch sw = new Stopwatch();

    sw.Start();
    RealizarOperacao(1, "Fulano", "da Silva");
    sw.Stop();

    Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milissegundos.");
    }

    static void RealizarOperacao(int op, string nome, string sobrenome)
    {
            Console.WriteLine($"Iniciando operação {op}...");
            for (int i = 0; i < 1000000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 35);
            }
            Console.WriteLine($"Finalizando operação {op}...");
    }

    static void ExecutarComThreads()
        {
        var t1 = new Thread(() =>
        {
            RealizarOperacao(1, "Fulano", "da Silva");
        });

        var t2 = new Thread(() =>
        {
            RealizarOperacao(2, "Fulano", "da Silva");
        });

        var t3 = new Thread(() =>
        {
            RealizarOperacao(3, "Fulano", "da Silva");
        });
        }
        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }

    static void ExecutarComTasks()
    {
    var t1 = Task.Run(() =>
    {
        RealizarOperacao(1, "Fulano", "da Silva");
    });

    var t2 = Task.Run(() =>
    {
        RealizarOperacao(2, "Fulano", "da Silva");
    });

    var t3 = Task.Run(() =>
    {
        RealizarOperacao(3, "Fulano", "da Silva");
    });
    }
}