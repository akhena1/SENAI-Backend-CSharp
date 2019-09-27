using System;
using System.Globalization;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Today is ");
            DiaDaSemana();
        }
        static void DiaDaSemana(){
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
