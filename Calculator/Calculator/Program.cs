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
            int fim = 1;
            int escolha;

            while (fim == 1)
            {
                Console.Clear();
                Console.WriteLine("escolha como quer fazer a conta: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - multiplicação");
                Console.WriteLine("4 - divisão");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("Você escolheu adição!");
                    Soma();                                                      //chamar a funcao soma
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Você escolheu subtração!");
                    Subtracao();
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Você escolheu Multiplicação!");
                    multiplicacao();
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Você escolheu divisão!");
                    divisao();
                }
                else
                {
                    Console.WriteLine("Valor errado, tente novamente!");
                }

                Console.WriteLine("Gostaria de calcular outro valor??");
                Console.WriteLine("(1) SIM");
                Console.WriteLine("(2) NÃO");
                fim = int.Parse(Console.ReadLine());
            }
        }
       private static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor a ser dividido: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float dividir = n1 / n2;
            Console.WriteLine($"\n\nO resultado é: {n1} / {n2} = {dividir}");
            Console.ReadKey();
        }

        private static void multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor a ser multiplicado: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float multiplicar = n1 * n2;
            Console.WriteLine($"\n\nO resultado é: {n1} x {n2} = {multiplicar}");
            Console.ReadKey();
        }

        private static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor a ser subtraido: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float subtrair = n1 - n2;
            Console.WriteLine($"\n\nO resultado é: {n1} + {n2} = {subtrair}");
            Console.ReadKey();
        }

        static void Soma()
         {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float somar = n1 + n2;
            //Console.WriteLine("O resultado da soma é = " + soma);
            Console.WriteLine($"\n\nO resultado é: {n1} + {n2} = {somar}");
            Console.ReadKey();
        }
        

    }
}



        