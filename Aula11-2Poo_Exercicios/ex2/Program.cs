using System;
using ex2.Controllers;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController Celular = new CelularController();

            
            Console.Clear();
            
            Celular.EnviarMensagem();
            System.Console.WriteLine();
            Celular.FazerLigacao();
            System.Console.WriteLine();
            Celular.Ligar();
            System.Console.WriteLine();
            Celular.EnviarMensagem();
            System.Console.WriteLine();
            Celular.FazerLigacao();
            System.Console.WriteLine();
            Celular.Desligar();
        }
    }
}
