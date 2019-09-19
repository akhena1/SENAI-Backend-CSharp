using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string resultado;
            
            Console.Write("Escreva qual o número que deseja saber a tabuada:  ");
            num = int.Parse( Console.ReadLine() );

            for ( int cont = 1; cont <= 10; cont++  ) {

                resultado = ($"{num} X {cont} = {num * cont}" );
                Console.WriteLine(resultado);


            }
        }
    }
}
