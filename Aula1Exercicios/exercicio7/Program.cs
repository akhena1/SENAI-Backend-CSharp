using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int passageiros;
            double total;
            
            Console.WriteLine("Digite a quantidade de passageiros que entraram");
            passageiros = int.Parse(Console.ReadLine());

            total = passageiros*4.30;
            Console.WriteLine($"Você arrecadou R${total} hoje!!!");

        }
    }
}
