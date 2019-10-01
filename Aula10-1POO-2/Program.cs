using System;
using Aula10_1POO_2.Controllers;
using Aula10_1POO_2.Models;

namespace Aula10_1POO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produto1 = new ProdutosController();



            produto1.CadastrarProduto();

            produto1.ExibirProduto();

        }
    }
}
