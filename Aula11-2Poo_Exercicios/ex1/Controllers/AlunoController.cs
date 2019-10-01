using System;
using ex1.Models;

namespace ex1.Controllers
{
    public class AlunoController
    {
        AlunoModel a1 = new AlunoModel();


        /// <summary>
        /// Função que cadastra o objeto aluno e valida se ele é bolsista ou não
        /// </summary>
        public void CadastrarAluno()
        {
            try
            {
               System.Console.WriteLine("Olá! Insira seu nome");
               a1.Nome = Console.ReadLine(); 

               System.Console.WriteLine("Insira qual seu curso");
               a1.Curso = Console.ReadLine();
               
               System.Console.WriteLine("Insira sua idade");
               a1.Idade = int.Parse(Console.ReadLine() );

               System.Console.WriteLine("Insira seu RG");
               a1.Rg = Console.ReadLine();
               
               System.Console.WriteLine("Você é bolsista?");
               a1.ValidacaoBolsista = Console.ReadLine().Replace("SIM","sim").Replace("Sim","sim").Replace("Não","nao").Replace("NÃO","nao").Replace("Nao","nao").Replace("NAO","nao");  
               

               if(a1.ValidacaoBolsista == "sim")
               {
                   a1.Bolsista = true;
               }
               else if(a1.ValidacaoBolsista == "nao")
               {
                   a1.Bolsista = false;
               }else{
                   System.Console.WriteLine("Digite 'sim' ou 'nao'. Com letras minúsculas e sem acentuação.");
               }
               
               

            }
            catch (Exception)
            {
                System.Console.WriteLine("Ops, parece que algo deu errado. Digite um comando válido :)");
            }
            
            

        }

        // Método que exibe o aluno cadastrado no sistema
        public void ExibirAluno()
        {
            System.Console.WriteLine("Nome: "+a1.Nome);
            System.Console.WriteLine("Curso: "+a1.Curso);
            System.Console.WriteLine("Idade: "+a1.Idade);
            System.Console.WriteLine("RG: "+a1.Rg);
            if(a1.Bolsista == true)
            {
                System.Console.WriteLine("O aluno é bolsista.");
            }
            else if(a1.Bolsista == false)
            {
                System.Console.WriteLine("O aluno não é bolsista");
            }
            
        }
    }
}