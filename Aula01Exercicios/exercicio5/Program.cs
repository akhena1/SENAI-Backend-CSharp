using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salario;
            double totalvendas;
            double salariototal;
            
            Console.WriteLine("Bem vindo! Qual o seu nome?");
            vendedor = Console.ReadLine();

            Console.WriteLine("Qual foi o seu salário esse mês?");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite em reais o valor das vendas efetuadas");
            totalvendas = double.Parse(Console.ReadLine());

            salariototal = salario + (totalvendas *0.1);
            Console.WriteLine($"Dados financeiros do vendedor{vendedor}");
            Console.WriteLine($"Salário fixo : R$ {salario}");
            Console.WriteLine($"O salário disponível deste mês é de {salariototal}");
        }
    }
}
