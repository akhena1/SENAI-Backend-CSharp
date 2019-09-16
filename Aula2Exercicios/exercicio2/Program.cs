using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            double total;
            double totaln;

            Console.WriteLine("Qual o valor total ??");
            total = double.Parse(Console.ReadLine());

            if ( total > 100 ){
                
                totaln = total - 25;
                Console.WriteLine($"O valor a ser pago é {totaln}");
            }
            else {
                Console.WriteLine($"O valor a ser pago é {total}");
            }
        }
    }
}
