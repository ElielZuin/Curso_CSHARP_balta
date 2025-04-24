using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("   MODO EDITOR");
            Console.WriteLine("-----------------");
            Start();
        }

        public static void Start() 
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } 
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            

            Console.WriteLine("----------------");
            Viewer.Show(file.ToString());
            Console.WriteLine(" Deseja salvar o arquivo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            
            var option = short.Parse(Console.ReadLine());
           
            switch(option){
                case 1: Salvar(file.ToString()); break;
                default: Show(); break;
                }
        }

       
       





        public static void Salvar(string file)
        {
            
            Console.WriteLine("Qual caminho para salvar o arquivo??");
            Console.WriteLine("C:/dev/nome arquivo.txt");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(file);
            }

            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }
    }
}
