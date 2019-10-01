using System;
using ex5.Controllers;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzasController pizza = new PizzasController();

            string decisao = "";

            while(decisao != "0")
            {
                
                System.Console.WriteLine(@"                                   Olá! Bem vindo a nossa Pizzaria
                                        Pressione 1 para Cadastrar um pedido de pizza
                                        Pressione 2 para Confirmar seu pedido
                                        Pressione 0 para sair.
");
                decisao = Console.ReadLine();
                
                switch (decisao)
                {   
                    case "1":
                        pizza.CadastrarPizza();
                    break;
                    
                    case "2":
                        pizza.ConfirmarPedido();
                    break;


                    case "0":
                        decisao = "0";
                    break;
                
                    default:
                        System.Console.WriteLine("Comando inválido! Insira um dos números informados no menu!");
                    break;
                }
            }

            

            
            
        }
    }
}
