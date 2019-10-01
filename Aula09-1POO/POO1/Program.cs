using System;
using POO1.Models;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando objeto
            AlunoModel aluno = new AlunoModel(); //Instanciando objeto

            System.Console.WriteLine("Insira seu nome");
            aluno.Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o nome do seu curso");
            aluno.Curso = Console.ReadLine();

            System.Console.WriteLine("Insira seu RA");
            aluno.RA = Console.ReadLine();
            
            System.Console.WriteLine("Insira sua idade");
            aluno.Idade = int.Parse(Console.ReadLine() );

            System.Console.WriteLine("Nome: " + aluno.Nome);
            System.Console.WriteLine("Curso: " + aluno.Curso);
            System.Console.WriteLine("RA: " + aluno.RA);
            System.Console.WriteLine("Idade: " + aluno.Idade);
            
        }
    }
}
