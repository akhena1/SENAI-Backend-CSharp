using System;

namespace Aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos as notas que utilizaremos

            float nota1;
            float nota2;
            float nota3;
            float media;
            string resultado;


            //Capturamos as notas

            Console.WriteLine("Escreva sua nota da primeira prova");
            nota1 = float.Parse(Console.ReadLine() );

            Console.WriteLine("Escreva sua nota da segunda prova");
            nota2 = float.Parse(Console.ReadLine() );

            Console.WriteLine("Escreva sua última nota");
            nota3 = float.Parse(Console.ReadLine() );
            

            //Calculamos a média

            media = (nota1 + nota2 + nota3) /3;

            
            //Verificamos se a média do aluno é maior ou igual à 6

            if(media >= 6){
               
                resultado = ("Aprovado!");
            }
            else{

                //Verificamos se a média é maior ou igual a 4 E e menor que 6

                if(media >= 4 && media < 6 ){

                    resultado = ("Recuperação!");
                }
                else{

                    resultado = ("Reprovado!");
                }

            }
            Console.WriteLine($"Média : {media} - Aluno está {resultado}");
        }   
    }
}
