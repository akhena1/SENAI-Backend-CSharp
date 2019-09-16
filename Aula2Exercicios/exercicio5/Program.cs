using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   

            double valor1;
            double valor2;
            double valor3;
            
            Console.WriteLine("Digite um número");
            valor1 = double.Parse(Console.ReadLine() );

            Console.WriteLine("Digite mais um número");
            valor2 = double.Parse(Console.ReadLine() );

            Console.WriteLine("Digite um último número");
            valor3 = double.Parse(Console.ReadLine() );

            if ( valor1 > valor2 && valor1 > valor3 ){
                Console.WriteLine($"o maior número é o {valor1}");
            }
            else{
                if ( valor2 > valor1 && valor2 > valor3 ){
                    Console.WriteLine( $"o maior número é o {valor2} " );
                }
                else{
                    Console.WriteLine( $"O maior número é o {valor3} " );
                }

            }
        }
    }
}
