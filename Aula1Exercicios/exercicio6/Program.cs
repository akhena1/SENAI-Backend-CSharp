using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldofixo;
            double debits;
            double saldodisponivel;

            
            Console.WriteLine("Digite o seu salário deste mês");
            saldofixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite em reais o valor da sua dívida mensal");
            debits = double.Parse(Console.ReadLine());

            saldodisponivel = saldofixo - debits;
            Console.WriteLine($"Este mês você tem R${saldodisponivel} sobrando");

        }
    }
}
