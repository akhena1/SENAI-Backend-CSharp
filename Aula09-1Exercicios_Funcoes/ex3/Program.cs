using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {   

            string nome;
            string sobrenome;
            float idade;
            float peso;
            float altura;

            Console.WriteLine(MostraInfo());

            System.Console.WriteLine();//espaço
            try
            {
                Console.Write("Insira seu nome: ");
                nome = Console.ReadLine();

                System.Console.WriteLine();//espaço

                System.Console.Write("Insira seu sobrenome: ");
                sobrenome = Console.ReadLine();

                System.Console.WriteLine("Obrigado!");
                System.Console.WriteLine("Agora insira sua idade");
                idade = float.Parse(Console.ReadLine().Replace("anos","").Replace(" anos", "") );

                System.Console.WriteLine("Digite seu peso");
                peso = float.Parse(Console.ReadLine().Replace("kg","").Replace("Kg","").Replace("KG","") );

                System.Console.WriteLine("Digite sua altura");
                altura = float.Parse(Console.ReadLine().Replace("cm","").Replace("m","").Replace(" cm","").Replace(" m","") ); 

                Console.WriteLine(MostraInfo(nome , sobrenome));

                Console.WriteLine(MostraInfo(idade, peso, altura));
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ops! Parece que você inseriu um comando inválido");
            }
            

            
            
        }

            
            

            


        /// <summary>
        /// Função que exibe um texto
        /// </summary>
        static string MostraInfo()
        {
            return "SERVICO NACIONAL DE APRENDIZAGEM INDUSTRIAL - SENAI";
        }


        /// <summary>
        /// função que retorna o nome e o sobrenome juntos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <returns>Nome Completo</returns>
        static string MostraInfo(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
            


        /// <summary>
        /// Função que retorna os dados inseridos com um texto predefinido
        /// </summary>
        /// <param name="idade"></param>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        static string MostraInfo(float idade, float peso, float altura)
        {
            string resultado = "Idade: "+idade.ToString()+" Peso: "+peso.ToString()+" Altura: "+altura.ToString();
            
            return resultado;
        }

    }
}
