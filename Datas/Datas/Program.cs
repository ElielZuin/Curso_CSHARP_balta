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

            var data = new DateTime(2025, 04, 24, 23,53,38);
            
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }
    }
}
