using System;
using ex4.Models;

namespace ex4.Controllers
{
    public class CalculadorasController
    {
        CalculadoraModel cn = new CalculadoraModel();

        //Método para efetuar soma de dois digitos
        public void Soma()
        {
            
            double resultado;

            try
            {
                System.Console.WriteLine("Digite o primeiro valor");
                cn.Digito1 = double.Parse(Console.ReadLine() );
                System.Console.WriteLine("Digite o valor que deseja somar");
                cn.Digito2 = double.Parse(Console.ReadLine() ); 
            }
            catch (Exception)
            {
                System.Console.WriteLine("Comando inválido");
            }
            
            resultado = cn.Digito1 + cn.Digito2;
            Console.WriteLine($"A soma dos valores informados é {resultado}");
        }

        //Método para subtrair 2 digitos
        public void Subtracao()
        {

            double resultado;

            try
            {
                System.Console.WriteLine("Digite o primeiro valor");
                cn.Digito1 = double.Parse(Console.ReadLine() );
                System.Console.WriteLine("Digite o valor que deseja subtrair");
                cn.Digito2 = double.Parse(Console.ReadLine() ); 
            }
            catch (Exception)
            {
                System.Console.WriteLine("Comando inválido");
            }
            
            resultado = cn.Digito1 - cn.Digito2;
            Console.WriteLine($"A subtração dos valores informados é {resultado}");
        }

        //Método que multiplica 2 dígitos
        public void Multiplicacao()
        {

            double resultado;
            try
            {
                System.Console.WriteLine("Digite o primeiro valor");
                cn.Digito1 = double.Parse(Console.ReadLine() );
                System.Console.WriteLine("Digite o valor que deseja multiplicar");
                cn.Digito2 = double.Parse(Console.ReadLine() ); 
            }
            catch (Exception)
            {
                System.Console.WriteLine("Comando inválido");
            }
            
            
            resultado = cn.Digito1 * cn.Digito2;
            Console.WriteLine($"A multiplicação dos valores informados é {resultado}");
        }

        //Método que divide dois digitos.
        public void Divisao()
        {

            double resultado;
            try
            {
                System.Console.WriteLine("Digite o primeiro valor");
                cn.Digito1 = double.Parse(Console.ReadLine() );
                System.Console.WriteLine("Digite o valor pelo qual você deseja dividir");
                cn.Digito2 = double.Parse(Console.ReadLine() ); 
            }
            catch (Exception)
            {
                System.Console.WriteLine("Comando inválido");
            }
            
            
            resultado = cn.Digito1 / cn.Digito2;
            Console.WriteLine($"A divisão dos valores informados é {resultado}");
        }
    }
}