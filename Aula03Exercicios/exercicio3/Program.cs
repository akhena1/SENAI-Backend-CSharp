using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int n = 0;

            Console.WriteLine("Você quer saber os múltiplos de 5 de 1 até qual número? digite ele abaixo");
            n = int.Parse(Console.ReadLine() );
            
            while( cont != n  ){
                
                if( cont % 5 == 0 ){

                    Console.WriteLine(cont);

                }
            
                cont++;

            }
        }
    }
}
