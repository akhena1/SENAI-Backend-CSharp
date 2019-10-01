using System;
using ex3.Models;

namespace ex3.Controllers
{
    public class ProdutosController
    {
        ProdutoModel produto = new ProdutoModel();

        //Método que cadastra o produto
        public void CadastrarProduto()
        {
            try
            {
               System.Console.WriteLine("Insira o ID");
               produto.IdProduto = Console.ReadLine();
             
               System.Console.WriteLine("Insira o Modelo");
               produto.Modelo = Console.ReadLine();
               
               System.Console.WriteLine("Insira a cor");
               produto.Cor = Console.ReadLine();
               
               System.Console.WriteLine("Insira o preço");
               produto.Preco =  double.Parse(Console.ReadLine());

               Console.WriteLine("Produto cadastrado!");


            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Parece que você inseriu um comando inválido! Tente novamente.");
            }
            
        }

        //Método para exibir o produto
        public void ExibirProduto()
        {
            
            System.Console.WriteLine();
            System.Console.WriteLine("Produto:");
            System.Console.WriteLine(produto.IdProduto);
            System.Console.WriteLine(produto.Modelo);
            System.Console.WriteLine(produto.Cor);
            System.Console.WriteLine(produto.Preco);
        }

        //Método que valida a reserva do produto
        public void ReservarProduto()
        {
            try
            {
                System.Console.WriteLine("Deseja reservar o produto? digite 'sim' ou 'nao'.");
                produto.ReservaValidator = Console.ReadLine().Replace("SIM","sim").Replace("Sim","sim").Replace("Não","nao").Replace("NÃO","nao").Replace("Nao","nao").Replace("NAO","nao");
               
                if(produto.ReservaValidator == "sim")
                {
                   produto.Reserva = true;
                   System.Console.WriteLine("Produto reservado!");
                }
                else if( produto.ReservaValidator == "nao")
                {
                    produto.Reserva = false;
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Comando inválido, digite novamente");
            }
        }
    }
}