using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)     //programa principal
        {
            int fim = 1; //determinar o fim do programa
            int escolha; //escolher qual operacao que sera feita

            while (fim == 1)    //while que detecta o fim do programa, se  fim = 1 entao ele roda o programa em loop, caso for outro valor
            {                                                                                             //ele para e finaliza o programa
                Console.Clear();    //limpar o cmd
                Console.WriteLine("escolha como quer fazer a conta: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - multiplicação");
                Console.WriteLine("4 - divisão");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: Soma(); break;                //chamar a funcao soma
                    case 2: Subtracao(); break;
                    case 3: Multiplicacao(); break;
                    case 4: Divisao(); break;
                    default: Console.WriteLine("Digite um valor de 1 a 4!"); break;
                }
                
                Console.WriteLine("Gostaria de calcular outro valor??");    //para finalizar o loop (nesse caso, o programa)
                Console.WriteLine("(1) SIM");
                Console.WriteLine("(2) NÃO");
                fim = int.Parse(Console.ReadLine());
            }
        }
       private static void Divisao()        //declaracao da funcao da divisao
        {
            Console.Clear();    //limpar o que ja estava escrito no cmd
            Console.WriteLine("Digite o primeiro valor a ser dividido: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float dividir = n1 / n2;
            Console.WriteLine($"\n\nO resultado é: {n1} / {n2} = {dividir}");
            Console.ReadKey();
        }

        private static void Multiplicacao()     //declaracao da funcao da multiplicacao
        {
            Console.Clear();        //limpar o que ja estava escrito no cmd
            Console.WriteLine("Digite o primeiro valor a ser multiplicado: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float multiplicar = n1 * n2;
            Console.WriteLine($"\n\nO resultado é: {n1} x {n2} = {multiplicar}");
            Console.ReadKey();      //impede que a tela saia sem apertar algo
        }

        private static void Subtracao()         //declaracao da funcao da subtracao
        {
            Console.Clear();        //limpar o que ja estava escrito no cmd
            Console.WriteLine("Digite o primeiro valor a ser subtraido: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float subtrair = n1 - n2;
            Console.WriteLine($"\n\nO resultado é: {n1} + {n2} = {subtrair}");
            Console.ReadKey();      //impede que a tela saia sem apertar algo
        }

        static void Soma()      //declaracao da funcao da soma
        {  
            Console.Clear();        //limpar o que ja estava escrito no cmd
            Console.WriteLine("Digite o Primeiro Valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor: ");
            float n2 = float.Parse(Console.ReadLine());
            float somar = n1 + n2;
                    //Console.WriteLine("O resultado da soma é = " + soma);         forma alternativa de fazer!!!!!
            Console.WriteLine($"\n\nO resultado é: {n1} + {n2} = {somar}"); //exibe o resultado
            Console.ReadKey();  //impede que a tela saia sem apertar algo
        }
        

    }
}



        