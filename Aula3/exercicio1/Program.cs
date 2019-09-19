using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int cont = 1;
            string acum = "";

            do{
                
                Console.Write("Escreva um número inteiro:  ");
                numero1 = int.Parse(Console.ReadLine() );

                

                if( numero1 % 3 == 0 ){
                    
                    acum += " - "+numero1.ToString();

                    
                    
                }
                cont++;

                
            }while( cont <= 20 );
            
            Console.WriteLine($"{acum} são os números multiplos de 3");


        }
    }
}
