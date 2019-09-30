using System;
using Aula10_1POO_Exercicio.Controllers;

namespace Aula10_1POO_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController p1 = new PessoaController();

            string sair = "";

            p1.CadastrarPessoa();

            p1.ExibirPessoa();

            System.Console.WriteLine("Deseja calcular seu IMC? Digite OK para sim, e 0 para não");
            sair = Console.ReadLine();

            switch(sair)
            {
                case "OK":
                    
                    p1.CalculoImc();
                break;
                
                case "0":
                    System.Console.WriteLine("Obrigado por utilizar nosso sistema");
                break;

                default:
                    System.Console.WriteLine("Comando inválido");
                break;

            }



        }
    }
}
