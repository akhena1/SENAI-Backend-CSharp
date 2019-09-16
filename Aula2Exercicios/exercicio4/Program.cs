using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            double total;
            double desconto;

            Console.WriteLine("Olá! Será que você tem direito ao desconto?");
            Console.WriteLine("Digite o valor da sua compra");
            total = double.Parse(Console.ReadLine() );

            if ( total > 100 && total < 1000 ){
                
                desconto = total - total*15/100;
                Console.WriteLine( "Você tem direito ao desconto!" );
                Console.WriteLine($"O valor a ser pago é R${desconto} " );
            }
            else{
                Console.WriteLine( "Infelizmente você não tem direito ao desconto :(" );
                Console.WriteLine($"O valor a ser pago é R${total} " );
            }
        }
    }
}
