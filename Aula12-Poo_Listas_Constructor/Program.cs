using System;
using System.Collections.Generic;
using Aula12_Poo_Listas_Constructor.Models;

namespace Aula12_Poo_Listas_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nossa classe com o método construtor passando os parâmetros
            ProdutoModel produto = new ProdutoModel(1, "Maçã", "Verde", 3.5);

            // Chamamos um atributo do objeto instanciado
            Console.WriteLine(produto.NomeProduto);

            //Instanciamos nossa classe sem passar parâmetros utilizando sobrecarga
            ProdutoModel produtoSobrecarga = new ProdutoModel();

            //Alimentamos nossso objeto que estava vazio
            produtoSobrecarga.IdProduto = 1;
            produtoSobrecarga.NomeProduto = "Melão";
            produtoSobrecarga.Descricao = "Amarelo";
            produtoSobrecarga.Preco = 5.50;

            // Chamamos a nossa lista que vai ser do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos instanciados e atribuídos em nossa lista
            prod.Add( new ProdutoModel(1, "Cenoura", "Laranja", 2.30) );
            prod.Add( new ProdutoModel(2, "Mamão", "Laranja", 2.30) );
            prod.Add( new ProdutoModel(3, "Beterraba", "Laranja", 2.30) );
            prod.Add( new ProdutoModel(4, "Pastel", "Laranja", 2.30) );
            prod.Add( new ProdutoModel(5, "Caldo de cana", "Laranja", 2.30) );
            prod.Add( new ProdutoModel(6, "Chuchu", "Laranja", 2.30) );

            // Lemos os dados da nossa lista
            foreach (ProdutoModel p in prod)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(p.IdProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }

            // Chamamos através do índice um atributo específico
            System.Console.WriteLine(prod[4].NomeProduto);
        }
    }
}
