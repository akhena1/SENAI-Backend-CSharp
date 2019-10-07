using System;
using System.Collections.Generic;
using ex2.Models;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProdutoModel> p = new List<ProdutoModel>();

            p.Add( new ProdutoModel("1", "Sapato","Amarelo",89.99,true));
            p.Add( new ProdutoModel("2", "Camisa","Preta",79.99,true));
            p.Add( new ProdutoModel("3", "Calça","Vermelha",119.99,false));
            p.Add( new ProdutoModel("4", "Boné","Azul",89.99,true));
            p.Add( new ProdutoModel("5", "Óculos","Escuros",89.99,false));

            foreach(ProdutoModel p1 in p)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("ID: "+p1.IdProduto);
                System.Console.WriteLine("Modelo: "+p1.Modelo);
                System.Console.WriteLine("Cor: "+p1.Cor);
                System.Console.WriteLine("Preço: "+p1.Preco);
                System.Console.WriteLine("Reserva: "+p1.Reserva);
                System.Console.WriteLine();
            }
        }
    }
}
