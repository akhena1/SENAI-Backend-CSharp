using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor1 = new int [10];
            int [] vetor2 = new int [10];
            int [] vetor3 = new int [20];

            Console.WriteLine("Escreva uma sequência de 10 números para a primeira sequência, e 10 para a segunda. Pressione enter para enviar cada número");
            
            for(int i = 0; i <=9; i++){

                vetor1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Segunda sequência");
            for(int i = 0; i <=9; i++){

                
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <=9; i++){

                vetor3[i] = vetor1[i];
            }
            for(int i = 10; i <=19; i++){

                vetor3[i] = vetor2[i-10];
            }

            Console.WriteLine();

            for(int i = 0; i <=19; i++){
            
                Console.WriteLine(vetor3[i]);

            }



        }
    }
}
