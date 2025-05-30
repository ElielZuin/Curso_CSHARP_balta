﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHTML
{
    public class Viewer
    {
        
        public static void Open()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Qual o caminho do arquivo?");
            Console.WriteLine("C:/dev/nome arquivo.txt");
            Console.WriteLine("--------------------------\n");
            string caminho = Console.ReadLine();

            using (var arquivo = new StreamReader(caminho))
            {
                string text = arquivo.ReadToEnd();
                Replace(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu.Show();
        }

        
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("   MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------------------");
            Replace(text);
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); //so copiar isso e colar
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) - 
                                words[i].IndexOf('>')
                            )
                        )
                    ); 
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }


        }







    }
}
