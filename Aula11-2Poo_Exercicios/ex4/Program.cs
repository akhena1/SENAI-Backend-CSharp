using System;
using ex4.Controllers;
using ex4.Models;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            CientificaController cc = new CientificaController();
            CalculadoraModel cn = new CalculadoraModel();

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
                        try
                        {
                            System.Console.WriteLine("Digite o primeiro valor");
                            cn.Digito1 = double.Parse(Console.ReadLine() );
                            System.Console.WriteLine("Digite o valor que deseja somar");
                            cn.Digito2 = double.Parse(Console.ReadLine() ); 
                         }
                        catch (Exception)
                        {
                            System.Console.WriteLine("Comando inválido");
                        }

                        System.Console.WriteLine("A soma dos valores informados é: "+cc.Soma(cn.Digito1, cn.Digito2));
                    break;
                    
                    case "2":
                        try
                        {
                            System.Console.WriteLine("Digite o primeiro valor");
                            cn.Digito1 = double.Parse(Console.ReadLine() );
                            System.Console.WriteLine("Digite o valor que deseja subtrair");
                            cn.Digito2 = double.Parse(Console.ReadLine() ); 
                        }
                        catch (Exception)
                        {
                            System.Console.WriteLine("Comando inválido");
                        }
                        Console.WriteLine("A subtração dos valores informados é: "+cc.Subtracao(cn.Digito1, cn.Digito2));
                        break;

                    case "3":
                        try
                        {
                            System.Console.WriteLine("Digite o primeiro valor");
                            cn.Digito1 = double.Parse(Console.ReadLine() );
                            System.Console.WriteLine("Digite o valor que deseja multiplicar");
                            cn.Digito2 = double.Parse(Console.ReadLine() ); 
                        }
                        catch (Exception)
                        {
                            System.Console.WriteLine("Comando inválido");
                        }
                    
                        Console.WriteLine("A multiplicação dos valores informados é: "+cc.Multiplicacao(cn.Digito1, cn.Digito2));
                    break;

                    case "4":
                        try
                        {
                                System.Console.WriteLine("Digite o primeiro valor");
                                cn.Digito1 = double.Parse(Console.ReadLine() );
                                System.Console.WriteLine("Digite o valor pelo qual você deseja dividir");
                                cn.Digito2 = double.Parse(Console.ReadLine() ); 
                        }
                        catch (Exception)
                        {
                                System.Console.WriteLine("Comando inválido");
                        }
                        System.Console.WriteLine("A multiplicação dos valores informados é: "+cc.Divisao(cn.Digito1, cn.Digito2));
                        
                    break;

                    case "5":
                        try
                        {
                                System.Console.WriteLine("Insira a base da sua potenciação");
                                cn.Digito1 = double.Parse(Console.ReadLine() );
                                System.Console.WriteLine("Insira a sua potencia");
                                cn.Digito2 = double.Parse(Console.ReadLine() ); 
                        }
                        catch (Exception)
                        {
                                System.Console.WriteLine("Comando inválido");
                        }
                        System.Console.WriteLine("A potenciação dos valores informados é: "+cc.Potencia(cn.Digito1, cn.Digito2));
                        
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
