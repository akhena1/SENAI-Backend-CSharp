using System;

namespace Aula9_1Exercicios_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            double valor = 0;
            double porcentagem = 0;

            Console.WriteLine($"O valor final será R${Exercicio1(valor, porcentagem)}");

        }
        static double Exercicio1(double valor, double porcentagem){
            
            Console.WriteLine("Insira o valor");
            valor = double.Parse(Console.ReadLine() );

            Console.WriteLine("Quantos porcento deseja descontar?");
            porcentagem = double.Parse(Console.ReadLine());

            
            porcentagem = porcentagem /100;
            double desconto = valor*porcentagem;
            valor = valor - desconto;
            
            

            return valor;


        }
        
        
    }
}
