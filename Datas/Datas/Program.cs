using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var data = new DateTime();

            //var data = DateTime.Now;
            FormatandoDatas();


        }

        private static void CriandoDataNova()
        {
            var data = new DateTime(2025, 04, 25, 00, 57, 00);

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);

            Console.WriteLine((int)data.DayOfWeek);
        }

        static void FormatandoDatas()
        {
            Console.Clear();
            var data = DateTime.Now;

            // y -> Ano
            // M -> Mes
            // d -> Dia
            // h -> Hora
            // m -> Minuto
            // s -> Segundo
            // ff -> fracao de segundo
            // zzz -> timezone (-3uth)

            var formatada = String.Format("{0:yyyy}", data); //assim so exibe o ano
                                                              // se for 0:y ele exibe
                                                              // o mes por extenso e
                                                              // o ano
            // mas se for 0:M ele exibe o mes e o dia
            Console.WriteLine(formatada);

            var formatada1 = String.Format("{0:dd/MM/yyyy }", data);
            
            Console.WriteLine(formatada1);

            var formatardata = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
            Console.WriteLine(formatardata);

        }

        static void PadroesDeFormatacao()
        {
            var data = DateTime.Now;
            var formatada = String.Format("{0:d}", data); //exibe a menor data possivel
            //da mesma forma; T maiusculo exibe o tempo longo ex 1:54:32 PM
            // D maiusculo exibe por extenso o nome do dia e tal
            // f combina data e hora
            // g combina data e hora so que no short( curto)
            
            
            Console.WriteLine(formatada);
        }
    }
}
