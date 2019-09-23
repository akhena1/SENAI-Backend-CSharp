using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeProduto = new string[12];
            string[] corProduto = new string[12];
            string[] tamanhoProduto = new string[12];
            double[] priceProduto = new double[12];

            string produto;
            string cor;
            string tamanho;
            double price;

            string produtoDescribe;

            int id;

            Console.WriteLine("Insira o Nome, cor, tamanho, e preço de 12 produtos. Pressione enter após cada tópico para enviar;");

            for(int i = 0; i < nomeProduto.Length; i++){

                nomeProduto[i] = Console.ReadLine();
                corProduto[i] = Console.ReadLine();
                tamanhoProduto[i] = Console.ReadLine();
                priceProduto[i] = double.Parse(Console.ReadLine() );
                
                Console.WriteLine($"produto {i + 1} cadastrado!");

                

                
            }
            
            //EXAMPLE
                Console.WriteLine("Digite o número do produto que deseja consultar");
                id = int.Parse(Console.ReadLine() );


                produto = nomeProduto[id - 1];
                cor = corProduto[id - 1];
                tamanho = tamanhoProduto[id - 1];
                price = priceProduto[id - 1];

                produtoDescribe = ( $" Nome :{produto}\n Cor:{cor}\n Tamanho:{tamanho}\n Preço: R${price}");

                Console.WriteLine(produtoDescribe);
                                      
            

                



        }
    }
}
