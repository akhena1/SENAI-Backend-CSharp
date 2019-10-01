using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]vetor1 = new int[10];
            int[]vetor2 = new int [10];
            int[]vetor3 = new int [10];

            Console.WriteLine("Digite uma sequência de 10 números. Aperte enter para enviar cada um");

            for (int i = 0; i <= 9; i++){

                vetor1[i] = int.Parse(Console.ReadLine() );

            }

            Console.WriteLine("Digite mais uma sequência de 10 números. ");

            for ( int i = 0; i <= 9; i++ ){

                vetor2[i] = int.Parse(Console.ReadLine() );

            }

                Console.WriteLine();

            for ( int i = 0; i <= 9; i++ ){

                vetor3[i] += vetor1[i];
                vetor3[i] += vetor2[i];

                
                Console.WriteLine(vetor3[i]);

            }

        }
    }
}
