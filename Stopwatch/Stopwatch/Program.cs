using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--Cronometro--\n\n");
            Console.WriteLine("s = segundos     => use 10s -> 10 segundos");
            Console.WriteLine("m = minutos      => use 10m -> 10 minutos");
            Console.WriteLine("h = horas        => use 10h -> 10 horas");
            Console.WriteLine("0 = SAIR\n");
            Console.WriteLine("\n Quanto tempo deseja contar?");
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(900);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
        }

    }
}
