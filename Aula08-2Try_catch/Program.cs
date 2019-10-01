using System;

namespace Aula8_2
{
    class Program
    {
        static void Main(string[] args)
        {   


            int numero;
            
            //Escrevemos um bloco de código.
            try
            {
                Console.WriteLine("Digite um número");
                numero = int.Parse(Console.ReadLine() );
            }
            // try catch mostrando a exceção da regra.
            // erro gerado na aplicação.
            catch (Exception ex)
            {
                Console.WriteLine("Ops :( Deu ruim. Erro: "+ ex );
            
            }


            //try catch sem mostrar a exceção da regra.
            try
            {
                Console.WriteLine("Digite um número");
                numero = int.Parse(Console.ReadLine() );
            }
            catch (Exception)
            {
                Console.WriteLine("Ops :( Deu ruim. Erro: ");
            
            }


        }   
    }
}
