using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.Clear();
            Soma();
            Subtracao();
            multiplicacao();
            divisao();
        }

        private static void divisao()
        {
            Console.WriteLine("Digite o primeiro valor a ser dividido: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float dividir = n1 / n2;
            Console.WriteLine($"O resultado é: {n1} / {n2} = {dividir}");
            Console.ReadKey();
        }

        private static void multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor a ser multiplicado: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float multiplicar = n1 * n2;
            Console.WriteLine($"O resultado é: {n1} x {n2} = {multiplicar}");
            Console.ReadKey();
        }

        private static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor a ser subtraido: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float subtrair = n1 - n2;
            Console.WriteLine($"O resultado é: {n1} + {n2} = {subtrair}");
            Console.ReadKey();
        }

        static void Soma()
         {
            Console.WriteLine("Digite o Primeiro Valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float somar = n1 + n2;
            //Console.WriteLine("O resultado da soma é = " + soma);
            Console.WriteLine($"O resultado é: {n1} + {n2} = {somar}");
            Console.ReadKey();
        }
        

    }
}



        