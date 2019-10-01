using System;
using ex1.Controllers;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController a1 = new AlunoController();

            a1.CadastrarAluno();
            System.Console.WriteLine("");
            a1.ExibirAluno();
            
        }
    }
}
