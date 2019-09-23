using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int []vetor = new int [10];
            int i = 0;

            while ( i <= 9){

                vetor[i] = (i*2);
                Console.WriteLine(vetor[i]);
                i++;
                
            }
        }
    }
}
