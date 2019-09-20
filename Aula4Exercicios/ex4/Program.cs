using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
           string[]words1 = new string[15];
           string[]words2 = new string[15];
           string[]text   = new string[30];
           
           
           Console.WriteLine("Escreva 15 palavras. Uma de cada vez. Pressione enter para enviar cada uma.");

           for (int i = 0; i <= 14; i++){
            
            words1[i] = Console.ReadLine();

           }

           Console.WriteLine("Escreva mais 15 palavras. ");
           
           for (int i = 0; i <= 14; i++){

               words2[i] = Console.ReadLine();

           }

           for (int i = 0; i <= 14; i++){

               text[i] = words1[i];

           }

           for (int i = 15; i <= 29; i++){

               text[i] = words2[i - 15];

           }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

           for (int i = 0; i <= 29; i++){

               Console.WriteLine(text[i]);

           } 


        }
    }
}
