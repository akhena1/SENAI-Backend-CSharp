﻿using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]nomeProduto = new string[12];
            string[]corProduto = new string[12];
            string[]tamanhoProduto = new string[12];
            double[]priceProduto = new double[12];

            string produto;
            string cor;
            string tamanho;
            double price;

            string produtoDescribe;

            int id;

            Console.WriteLine("Insira o Nome, cor, tamanho, e preço de 12 produtos. Pressione enter após cada tópico para enviar;");

            for(int i = 0; i <=11; i++){

                nomeProduto[i] = Console.ReadLine();
                corProduto[i] = Console.ReadLine();
                tamanhoProduto[i] = Console.ReadLine();
                priceProduto[i] = double.Parse(Console.ReadLine() );
                
                Console.WriteLine($"produto {i} cadastrado!");

                

                if(i != 11){

                    Console.WriteLine( "Descreva mais um");

                    
                }
                
            }
            
            //EXAMPLE

                Console.WriteLine("Digite o número do produto que deseja consultar");
                id = int.Parse(Console.ReadLine() );


                produto = nomeProduto[id];
                cor = corProduto[id];
                tamanho = tamanhoProduto[id];
                price = priceProduto[id];

                produtoDescribe = ( $" Nome :{produto}\n Cor:{cor}\n Tamanho:{tamanho}\n Preço: R${price}");

                Console.WriteLine(produtoDescribe);
                                      
            

                



        }
    }
}