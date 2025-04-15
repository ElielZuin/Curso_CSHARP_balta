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
            Console.WriteLine("-- Cronometro --\n\n");
            Console.WriteLine("s = segundos     => use 10s -> 10 segundos");
            Console.WriteLine("m = minutos      => use 10m -> 10 minutos");
            Console.WriteLine("h = horas        => use 10h -> 10 horas");
            Console.WriteLine("0 = SAIR\n");

            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            Console.WriteLine(type);
            Console.WriteLine(time);
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
