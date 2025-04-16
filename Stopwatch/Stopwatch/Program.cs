using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
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
            int fim = 1;
            while (fim == 1)
            {
                Menu();

                Console.WriteLine("\nDeseja atribuir outro valor para o cronometro?");
                Console.WriteLine("(0) Não");
                Console.WriteLine("(1) Sim");
                fim = int.Parse(Console.ReadLine());

                if (fim != 1)
                {
                    System.Environment.Exit(0);
                }
            }
        }

         

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-- Cronometro --\n\n");
            Console.WriteLine("s = segundos     => use 10s -> 10 segundos");
            Console.WriteLine("m = minutos      => use 10m -> 10 minutos");
            Console.WriteLine("h = horas        => use 10h -> 10 horas");

            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            

            if (type == 'm')
            {
                multiplier = 60;
            }

            else if (type == 'h')
            {
                multiplier = 60 * 60;
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
        }

    }
}
