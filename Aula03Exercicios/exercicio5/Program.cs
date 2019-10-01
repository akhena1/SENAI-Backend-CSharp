using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   

            int x;
            double salarioFuncionario;
            int cont = 1;
            string nomeFuncionario;
            string resultado = " ";
            double acumuladora = 0;
            double media;

            Console.WriteLine("Quantos funcionários você tem?");
            x = int.Parse(Console.ReadLine() );

            while( cont <=x ){

                Console.WriteLine( "Insira o nome do funcionário");
                nomeFuncionario = Console.ReadLine();

                Console.WriteLine( "Insira o salário do funcionário");
                salarioFuncionario = double.Parse(Console.ReadLine() );

                resultado = resultado + ($"{nomeFuncionario} ganha {salarioFuncionario}  -");

                Console.WriteLine(resultado);

                acumuladora+= salarioFuncionario;

                cont++;



            }

                media = acumuladora / x;

                Console.WriteLine($"A média salarial da sua empresa é de R$ {media}");
        }
    }
}
