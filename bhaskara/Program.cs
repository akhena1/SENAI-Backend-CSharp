using System;
using bhaskara.Controllers;
using bhaskara.Models;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            BhaskaraModel valores = new BhaskaraModel();
            BhaskaraController c = new BhaskaraController();


            Console.WriteLine("Bem vindo! vamos resolver uma Equação de 2° grau?");
            Console.WriteLine("Primeiro Identifique os valores de a, b, e c da Equação que deseja resolver");

            Console.WriteLine("Digite o valor A da equação");
            valores.a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            valores.b = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o valor de C");
            valores.c = double.Parse(Console.ReadLine());


            valores.x1 = c.CalculaX1(valores.a, valores.b, valores.c);
            valores.x2 = c.CalculaX2(valores.a, valores.b, valores.c);
            if(valores.x1 == 204 || valores.x2 == 204)
            {
                Console.WriteLine(" Não existe raizes reais para esta equação. Tente de novo ");
            }

            if(valores.x1 != 500 && valores.x1 != 204){
                Console.WriteLine($"As raízes dessa equação são {valores.x1} e {valores.x2} ");
            }
            else{
                Console.WriteLine("...");
            }
            

    


        }
    }
}
