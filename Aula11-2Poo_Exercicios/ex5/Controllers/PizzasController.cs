using System;
using ex5.Models;

namespace ex5.Controllers
{
    public class PizzasController
    {
        PedidoModel pizza = new PedidoModel();

        public void CadastrarPizza()
        {
            try
            {
                System.Console.WriteLine("Doce ou salgada?");
                pizza.Tipo = Console.ReadLine();

                System.Console.WriteLine("Insira o nome da pizza");
                pizza.Nome = Console.ReadLine();
                
                System.Console.WriteLine("Insira o preço");
                pizza.Preco = double.Parse(Console.ReadLine() );
                
                System.Console.WriteLine("Grande ou broto?");
                pizza.Tamanho = Console.ReadLine();
                
                System.Console.WriteLine("Pizza cadastrada!");
                System.Console.WriteLine();
                
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Digite um comando válido :)");
            }
        }
        public void ConfirmarPedido()
        {
            Console.Clear();
            System.Console.WriteLine();
            pizza.DataPedido = DateTime.Now;

            System.Console.WriteLine("Insira seu endereço");
            pizza.EnderecoEntrega = Console.ReadLine();
            
            pizza.PrevisaoEntrega = DateTime.Now.AddMinutes(30);

            System.Console.WriteLine("Tipo: "+pizza.Tipo);
            System.Console.WriteLine("Nome: "+pizza.Nome);
            System.Console.WriteLine("Preço: "+pizza.Preco);
            System.Console.WriteLine("Tamanho: "+pizza.Tamanho);
            System.Console.WriteLine("Data do pedido: "+pizza.DataPedido);
            System.Console.WriteLine("Endereço da entrega: "+pizza.EnderecoEntrega);
            System.Console.WriteLine("Previsão de entrega: "+pizza.PrevisaoEntrega);
            System.Console.WriteLine();
        }

        
    }
}