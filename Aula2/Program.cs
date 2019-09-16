using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {

           // Declaramos as notas que utilizaremos

            double nota1;
            double nota2;
            double nota3;
            double media;


            //Capturamos as notas

            Console.WriteLine("Escreva sua nota da primeira prova");
            nota1 = double.Parse(Console.ReadLine() );

            Console.WriteLine("Escreva sua nota da segunda prova");
            nota2 = double.Parse(Console.ReadLine() );

            Console.WriteLine("Escreva sua última nota");
            nota3 = double.Parse(Console.ReadLine() );
            

            //Calculamos a média

            media = (nota1 + nota2 + nota3) /3;

            
            //Verificamos se a média do aluno é maior ou igual à 6

            if(media >= 6){
               
                Console.WriteLine($"Você foi aprovado!, Obteve uma média de {media}" );
            }
            else{

                Console.WriteLine($"Você foi reprovado! Obteve uma média de {media}");

            }
        }
    }
}
