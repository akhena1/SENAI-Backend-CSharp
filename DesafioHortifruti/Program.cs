using System;

namespace DesafioHortifruti
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomeProduto = new string[10];
            double [] valorProduto = new double [10];
            
            string sair = "";

            int id;

            double acum = 0;

            while(sair != "0"){

                Console.WriteLine("Menu");
                Console.WriteLine("Pressione 1 para cadastrar um produto");
                Console.WriteLine("Pressione 2 para listar todos os produtos");
                Console.WriteLine("Pressione 3 para consultar um produto específico");
                Console.WriteLine("Pressione 4 para consultar oalor total dos produtos");
                
                sair = Console.ReadLine();

                switch(sair){
                    

                    case "1":

                     

                        for ( int i = 0; i <= 9; i++ ){

                            Console.WriteLine("Digite o nome do produto");
                            nomeProduto[i] = Console.ReadLine();

                            
    
                            Console.WriteLine("Digite o preço do produto");
                            valorProduto[i] = double.Parse(Console.ReadLine() );

                            Console.WriteLine("Produto cadastrado! ");
                        }

                    break;

                    case "2":
                       
                        for(int i = 0; i <= 9; i++){

                            Console.WriteLine(nomeProduto[i]);
                            Console.WriteLine("");
                            Console.WriteLine(valorProduto[i]);

                        }

                    break;

                    case "3":

                        Console.WriteLine("Digite o número do produto: ");
                        id = int.Parse(Console.ReadLine() );

                        Console.WriteLine("Nome: "+ nomeProduto[id - 1]);
                        Console.WriteLine("Preço: "+ valorProduto[id - 1]);


                    break;

                    case "4":
                        for(int i = 0; i <= 9; i++){
                            
                            acum += valorProduto[i];

                        
                        }

                        Console.WriteLine($"o total do valor em produtos é : {acum}");

                    break;
                    default:
                        Console.WriteLine("Comando inválido");
                    break;
                }
                
            }
        }
    }
}
