using System;

namespace Aula2_4Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int pedido;
            string resultado;
            

            Console.Write ("Por favor, digite o número do seu pedido:  ");
            pedido = int.Parse(Console.ReadLine());

            switch(pedido){

                case 1: 
                resultado = " Hamburguer ";
                break;

                case 2: 
                resultado = " Cheese Salada ";
                break;

                case 3: 
                resultado = " Cheese Burger ";
                break;

                case 4: 
                resultado = " Cheese bacon ";
                break;

                default:
                resultado = "Não há pedido com este número";
                break;
            }

            Console.WriteLine(resultado);

                

                       
        }
    }
}
