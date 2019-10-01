using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double salario;
            double divida;
            double saldo;
            
            Console.WriteLine("Qual o seu salário?");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o total das suas despesas esse mês?");
            divida = double.Parse(Console.ReadLine());

            saldo = salario - divida;

            if( divida > salario ){
                Console.WriteLine($"Ops, parece que há um déficit de R${saldo} em sua conta!");
            }
            else{
                Console.WriteLine($"Sua conta esta positiva! você tem R${saldo} disponível.");
            }
        }
    }
}
