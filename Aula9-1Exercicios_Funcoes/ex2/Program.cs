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

        /// <summary>
        /// Função que mostra o dia da semana
        /// </summary>
        static void DiaDaSemana(){
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
