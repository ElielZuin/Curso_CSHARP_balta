using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()   //isso é um metodo
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }


        public static void DrawScreen()
        {
            //cima
            TopoBaixo();
            //lados
            LinhasLado();
            //baixo
            TopoBaixo();
        }

        //quadrado desenhado do drawscreen
        public static void TopoBaixo()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void LinhasLado()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
        //fim do quadrado desenhado

        //Metodo que joga as opcoes na tela rapai
        public static void WriteOptions()
        {
            Console.SetCursorPosition(11, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("=========================");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção Escolhida: ");
            
        }

        public static void HandleMenuOption(short option) //handle = manipular algo
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Caminho(); break;
                case 0: 
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }

                default: Show(); break;

            }

        }


    }
}
