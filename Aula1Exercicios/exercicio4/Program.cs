using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float real;
            float dolar;
            float result;

            Console.WriteLine("Quantos reais deseja converter?");
            real = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a cotação do dolar hoje?");
            dolar = float.Parse(Console.ReadLine());

            result = real/dolar;
            Console.WriteLine($"O valor convertido resulta em R${result} dólares");
        }
    }
}
