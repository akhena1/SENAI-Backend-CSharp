using System;
using Aula10_1POO_Exercicio.Models;

namespace Aula10_1POO_Exercicio.Controllers
{
    public class PessoaController
    {
        PessoaModel p1 = new PessoaModel();

        public void CadastrarPessoa()
        {
            try
            {
               System.Console.WriteLine("Insira o nome");
                p1.Nome = Console.ReadLine();
            

                System.Console.WriteLine("Insira a idade");
                p1.Idade = int.Parse(Console.ReadLine());
            

                System.Console.WriteLine("Insira o peso(em quilogramas)");
                p1.Peso = double.Parse(Console.ReadLine());
            

                System.Console.WriteLine("Insira o altura(em metros)");
                p1.Altura = double.Parse(Console.ReadLine()); 
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("Ops, parece que algo deu errado :(");
            }
            
            

        }

        public void ExibirPessoa()
        {
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p1.Idade);
            System.Console.WriteLine(p1.Peso);
            System.Console.WriteLine(p1.Altura);
        }

        public void CalculoImc()
        {
            double resultado;

            resultado = p1.Peso / Math.Pow(p1.Altura,2);

            if(resultado <= 18.5)
            {
                Console.WriteLine("Você esta abaixo do peso!");
            }
            else if(resultado >18.5 && resultado <= 25)
            {
                System.Console.WriteLine("Ufa! seu peso esta na média");
            }
            else if(resultado > 25 && resultado <= 30)
            {
                System.Console.WriteLine("Parece que você esta um pouquinho acima do peso!");

            }
            else if(resultado > 30 && resultado <=35)
            {
                System.Console.WriteLine("Procure um profissional! Seu IMC indica um grau de obesidade");
            }
            else if(resultado > 35 && resultado <= 39)
            {
                System.Console.WriteLine("Seu Índice de massa corporal indica Obesidade grau II");
            }
            else if(resultado >=40)
            {
                System.Console.WriteLine("Altamente recomendado que você vá a um profissional! grau de obesidade 3");
            }
        }
        
    }
}