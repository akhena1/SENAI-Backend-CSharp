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
