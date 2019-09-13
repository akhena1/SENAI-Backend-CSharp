using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float vendas;
            float preçovendas;
            float total;
            
            Console.WriteLine("Digite seu salário fixo");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de vendas efetuadas");
            vendas = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor médio de cada venda");
            preçovendas = float.Parse(Console.ReadLine());

            total = salario + (preçovendas*vendas)*5/100;
            Console.WriteLine($"Seu salário este mês foi {total}");
        }
    }
}
