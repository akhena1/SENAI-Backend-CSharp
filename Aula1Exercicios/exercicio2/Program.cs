using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float custo;
            float lucrop;
            float P;
            
            
            Console.WriteLine("Qual o preço de custo da sua mercadoria?");
            custo = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de lucro desejada?");
            lucrop = float.Parse(Console.ReadLine());

            P = lucrop/100 *custo + custo;
            
            Console.WriteLine($"O preço da sua mercadoria será {P}");
        }
    }
}
