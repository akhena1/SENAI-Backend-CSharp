using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1;
            int valor2;

            Console.WriteLine("Insira o primeiro número");
            valor1 = int.Parse(Console.ReadLine() );

            Console.WriteLine("Insira o segundo número");
            valor2 = int.Parse(Console.ReadLine() );

            if ( valor1 > valor2 ){
                Console.WriteLine($"O valor {valor1} é maior");
            }
            else{
                if( valor1 < valor2 ){
                    Console.WriteLine($" O valor {valor2} é maior ");
                }
                else{
                    Console.WriteLine( "Os valores mencionados são iguais!" );
                }
            }

        }
    }
}
