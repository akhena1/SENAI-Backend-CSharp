using System;

namespace Aula9_1Exercicios_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            double valor = 0;
            double porcentagem = 0;

            try
            {
                Console.WriteLine("Insira o valor");
                valor = double.Parse(Console.ReadLine() );

                Console.WriteLine("Quantos porcento deseja descontar?");
                porcentagem = double.Parse(Console.ReadLine().Replace("%", ""));
            }
            catch (Exception)
            {
                Console.WriteLine("Ops! Parece que você inseriu um comando inválido");
            }
                
            Console.WriteLine($"O valor final será R${Exercicio1(valor, porcentagem)}");
                
            



        }


        /// <summary>
        /// Função que atribui desconto a um valor.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="porcentagem"></param>
        /// <returns>Valor com desconto</returns>
        static double Exercicio1(double valor, double porcentagem){

            
            porcentagem = porcentagem /100;
            double desconto = valor*porcentagem;
            valor = valor - desconto;
            
            

            return valor;


        }
        
        
    }
}
