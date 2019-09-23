using System;

namespace Aula4Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string  [] nomePassageiro = new string [5];
            string  [] origem         = new string [5];
            string  [] destino        = new string [5];
            DateTime[] data_ida       = new DateTime[5];
            DateTime[] data_volta     = new DateTime[5];

            string sair = "";
            string decisaoCadastro;

            while(sair != "0"){
                
                Console.WriteLine("Bem vindo ao nosso sistema de passagens");
                Console.WriteLine( @"
                Menu :
                1 - Cadastrar passagem
                2 - Lista de passagens
                0 - Sair");
                
                sair = Console.ReadLine();
               
                switch(sair){

                    case "1":
                        for(int i = 0; i <= 4; i++){
                            
                            Console.Write("Insira o nome: ");
                            nomePassageiro[i] = Console.ReadLine();

                            Console.Write("Digite o estado de origem: ");
                            origem[i] = Console.ReadLine();

                            Console.Write("Digite o seu destino: ");
                            destino[i] = Console.ReadLine();

                            Console.Write("Digite a sua data de voô: ");
                            data_ida[i] = DateTime.Parse(Console.ReadLine() );

                            Console.Write("Digite sua data de volta: ");
                            data_volta[i] = DateTime.Parse(Console.ReadLine() );
                        
                            
                            Console.WriteLine("Dados cadastrados com sucesso xD");
                            Console.WriteLine("Deseja cadastrar mais uma passagem?\n Digite a tecla S para sim e N para não");
                            
                            decisaoCadastro = Console.ReadLine();

                                if(decisaoCadastro == "N"){

                                    i = 4;

                                }
                        }
                    break;

                    case "2":
                        
                        for(int i = 0; i <= 4; i++){

                            if(nomePassageiro[i] != "" &&
                               origem[i]         != "" &&
                               destino[i]        != "" &&
                               data_ida[i]       != null &&
                               data_volta[i]     != null){

                                   Console.WriteLine();
                                   Console.WriteLine($"Passagem N°: {i + 1}");
                                   
                                   Console.WriteLine("Nome: "+nomePassageiro[i]);
                                   Console.WriteLine("Origem: "+origem[i]);
                                   Console.WriteLine("Destino: "+destino[i]);
                                   Console.WriteLine("Data de ida: "+data_ida[i]);
                                   Console.WriteLine("Data de volta: "+data_volta[i]);
                                   Console.WriteLine();


                            }
                        } 

                    break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistema!");
                    break;
                    default:
                        Console.WriteLine("Entrada inválida");
                    break;


                        
                } 
            }

            

        }
    }
}
