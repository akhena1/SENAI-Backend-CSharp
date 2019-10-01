using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoTerra;
            double planeta;
            double pesoET;
            string nomePlaneta = "404";
            double gravidade = 1.0;

            Console.WriteLine("Qual seria o seu peso em outro planeta?");

            Console.WriteLine("Digite o seu peso em quilos(kg)");
            pesoTerra = double.Parse(Console.ReadLine() );

            
            Console.WriteLine("Digite 1 para mércurio");
            Console.WriteLine("Digite 2 para Vênus ");
            Console.WriteLine("Digite 3 para Marte");
            Console.WriteLine("Digite 4 para Júpiter");
            Console.WriteLine("Digite 5 para Saturno");
            Console.WriteLine("Digite 6 para Urano");
            planeta = double.Parse(Console.ReadLine() );

            /* Eu tirei o calculo de dividir o peso por 10 pois o calculo fisico que mede seu peso
            em outro planeta é massa*gravidade */

            switch(planeta){
                
                case 1: 
                gravidade = 0.37;
                pesoET = pesoTerra * gravidade;
                nomePlaneta = "Mercúrio";
                Console.WriteLine( $"Uau! se você fosse até o planeta {nomePlaneta} pesaria {pesoET}kg" );
                break;

                case 2:
                
                gravidade = 0.88;
                pesoET = pesoTerra * gravidade;
                nomePlaneta = "Vênus";
                Console.WriteLine( $"Uau! se você fosse até o planeta {nomePlaneta} pesaria {pesoET}kg" );
                break;

                case 3:
                
                gravidade = 0.38;
                pesoET = pesoTerra * gravidade;
                nomePlaneta = "Marte";
                Console.WriteLine( $"Uau! se você fosse até o planeta {nomePlaneta} pesaria {pesoET}kg" );
                break;

                case 4:
                
                gravidade = 2.64;
                pesoET = pesoTerra * gravidade;
                nomePlaneta = "Júpiter";
                Console.WriteLine( $"Uau! se você fosse até o planeta {nomePlaneta} pesaria {pesoET}kg" );
                break;

                case 5:
                
                gravidade = 1.15;
                pesoET = pesoTerra * gravidade;
                nomePlaneta = "Saturno";
                Console.WriteLine( $"Uau! se você fosse até o planeta {nomePlaneta} pesaria {pesoET}kg" );
                break;

                case 6:
                
                gravidade = 1.17;
                pesoET = pesoTerra * gravidade;
                nomePlaneta = "Urano";
                Console.WriteLine( $"Uau! se você fosse até o planeta {nomePlaneta} pesaria {pesoET}kg" );
                break;

                default:
                Console.WriteLine("Número inválido, digite um número de planeta válido");
                break;


            }

            


        }
    }
}
