using System;
using ex3.Controllers;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController p1 = new ProdutosController();

            p1.CadastrarProduto();
            p1.ExibirProduto();
            p1.ReservarProduto();
        }
    }
}
