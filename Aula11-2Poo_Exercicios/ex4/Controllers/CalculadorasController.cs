using System;
using ex4.Models;

namespace ex4.Controllers
{
    public class CalculadorasController
    {
        CalculadoraModel cn = new CalculadoraModel();

        //Método para efetuar soma de dois digitos
        public double Soma(double v1, double v2)
        {
            
            return v1 + v2;
  
        }

        //Método para subtrair 2 digitos
        public double Subtracao(double v1, double v2)
        {

            return v1 - v2;
            
        }

        //Método que multiplica 2 dígitos
        public double Multiplicacao(double v1, double v2)
        {

            return v1 * v2;

        }

        //Método que divide dois digitos.
        public double Divisao(double v1, double v2)
        {

            return v1 / v2;
            
        }
    }
}