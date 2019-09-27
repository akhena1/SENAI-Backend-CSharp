using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {   
              double[] v1 = {1234, 1234, 1234, 1234, 6534};
              Console.WriteLine(MaiorIndice(v1));     
        }

        /// <summary>
        /// Função que capura o maior número de um vetor
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Maior conteúdo do vetor</returns>
        static double MaiorIndice(double[] valor)
        {
            double maior = 0;
                        
            foreach(double vetor in valor)
            {
                if(vetor == 0)
                {
                    maior = vetor;
                }
                else if(vetor > maior)
                {
                   maior = vetor; 
                }
            }

            return maior;
        }
    }
}
