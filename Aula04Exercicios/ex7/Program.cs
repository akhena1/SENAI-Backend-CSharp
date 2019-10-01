using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]vetor = new double[10];
            double maior = 0;
            int contador = 0;

            Console.WriteLine("Digite uma sequência de 10 números. Aperte enter para enviar cada um");

            for(int i = 0; i <= 9; i++){

                vetor[i] = int.Parse(Console.ReadLine() );

                if( i == 0){

                    maior = vetor[i];

                }
                if(vetor[i] > maior){

                    maior = vetor[i];
                    contador = i;

                }    
            }
            Console.WriteLine($"O maior número do vetor é o {maior} e ele esta localizado no índice {contador} do vetor");

        }
    }
}
