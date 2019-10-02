using System;
using ex4.Models;

namespace ex4.Controllers
{
    public class CientificaController : CalculadorasController //Herança de Classe
    {
        CalculadoraModel cn = new CalculadoraModel();

        //Método que faz um calculo de potência em 2 digitos
        public double Potencia(double v1, double v2){
        

           
          return Math.Pow(v1 , v2);
            
        }
    }
}