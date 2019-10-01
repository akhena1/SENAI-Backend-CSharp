using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            string impar = "";
            double acumuladora = 0;
            double media = 0;
            int contadora2 = 1;


            Console.WriteLine("Escreva os 20 valores abaixo");
            
            for ( int cont = 1; cont <=20; cont++){


                valor = double.Parse(Console.ReadLine() );
                 
                if( valor % 2 != 0 ){

                    impar += " - "+valor.ToString();

                }
                
                if( valor < 0 ){

                    acumuladora+=valor;
                    contadora2++;

                }
                media = acumuladora /contadora2;

                

            }
            
            Console.WriteLine("Os números ímpares são :");
            Console.WriteLine(impar);
            
            Console.WriteLine($"a média dos numeros negativos é : {media}");
                
          
        }
    }
}
