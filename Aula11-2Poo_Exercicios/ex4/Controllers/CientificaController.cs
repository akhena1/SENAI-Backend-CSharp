using System;
using ex4.Models;

namespace ex4.Controllers
{
    public class CientificaController : CalculadorasController //Herança de Classe
    {
        CalculadoraModel cn = new CalculadoraModel();

        //Método que faz um calculo de potência em 2 digitos
        public void Potencia()
        {
            double resultado;

            try
            {
                System.Console.WriteLine("Insira a base da sua potenciação");
                cn.Digito1 = double.Parse(Console.ReadLine() );
                System.Console.WriteLine("Insira a sua potencia");
                cn.Digito2 = double.Parse(Console.ReadLine() ); 
            }
            catch (Exception)
            {
                System.Console.WriteLine("Comando inválido");
            }
            
            
            resultado = Math.Pow(cn.Digito1 , cn.Digito2);
            Console.WriteLine($"A potenciação dos valores informados é {resultado}");
        }
    }
}