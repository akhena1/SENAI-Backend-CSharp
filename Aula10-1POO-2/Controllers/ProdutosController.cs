using System;
using System.IO;
using Aula10_1POO_2.Models;

namespace Aula10_1POO_2.Controllers
{
    public class ProdutosController
    {
        ProdutosModel produto = new ProdutosModel();
        public void CadastrarProduto()
        {   

            try
            {
                Console.WriteLine( "Digite o ID do produto: " );
                produto.IdProduto = int.Parse( Console.ReadLine() );

                Console.WriteLine( "Digite o nome do produto: " );
                produto.NomeProduto = Console.ReadLine();

                Console.WriteLine( "Digite a Descrição do produto: " );
                produto.Descricao = Console.ReadLine();

                Console.WriteLine( "Digite o preço do produto: " );
                produto.Preco = double.Parse( Console.ReadLine() );

                /* System.Console.WriteLine("Digite o ID do Fornecedor");
                produto.Fornecedor.IdFornecedor = int.Parse( Console.ReadLine() );

                System.Console.WriteLine("Digite o nome do Fornecedor");
                produto.Fornecedor.NomeFornecedor = Console.ReadLine(); */
            }
            catch (Exception ex)
            {
                Console.WriteLine("Desculpe :( houve um erro na aplicação");
                SalvarErros(ex);
                
            }
            
            
            
            
        }

        public void ExibirProduto()
        {
            System.Console.WriteLine(produto.IdProduto);
            System.Console.WriteLine(produto.NomeProduto);
            System.Console.WriteLine(produto.Descricao);
            System.Console.WriteLine(produto.Preco);

            /* System.Console.WriteLine(produto.Fornecedor.IdFornecedor);
            System.Console.WriteLine(produto.Fornecedor.NomeFornecedor); */
        }

        private void SalvarErros(Exception ex)
        {
            StreamWriter txt = new StreamWriter("error_log.txt",true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();

        }
    }
}