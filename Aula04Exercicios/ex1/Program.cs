using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];

            Console.WriteLine("Escreva uma sequência de 10 números. Pressione enter para enviar cada número");
            
            for(int i = 0; i <10; i++){

                
                num[i] = double.Parse( Console.ReadLine() );

            }
            
            for(int i = 0; i<10; i++){

                Console.WriteLine(num[i]);
            }
           
            Console.WriteLine();
            Console.WriteLine(num[9]*5);


        }
    }
}
