using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor1 = {10, 10, 10, 10};
            Console.WriteLine(VetorTotal(vetor1));
        }

        /// <summary>
        /// Função que captura o valor da soma de determinado vetor;
        /// </summary>
        /// <param name="vetor"></param>
        /// <returns></returns>
        static double VetorTotal(double[] vetor)
        {
            double acum = 0;

            foreach(double total in vetor )
            {
                
                acum += total;

            }
            return acum;
        }
    }
}
