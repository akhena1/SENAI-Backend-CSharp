using System;
using ex4.Controllers;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            CientificaController cc = new CientificaController();

            string decisao = "";
            
            
            //Menu do sistema da calculadora
            while(decisao != "0")
            {
                
                System.Console.WriteLine(@"                                   Olá! Bem vindo a nossa calculadora
                                        Pressione 1 para Somar
                                        Pressione 2 para Subtrair
                                        Pressione 3 para Multiplicar
                                        Pressione 4 para Dividir
                                        Pressione 5 para Calcular uma potência
                                        Pressione 0 para fechar o sistema");
                decisao = Console.ReadLine();
                
                switch (decisao)
                {   
                    case "1":
                        cc.Soma();
                    break;
                    
                    case "2":
                        cc.Subtracao();
                    break;

                    case "3":
                        cc.Multiplicacao();
                    break;

                    case "4":
                        cc.Divisao();
                    break;

                    case "5":
                        cc.Potencia();
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
