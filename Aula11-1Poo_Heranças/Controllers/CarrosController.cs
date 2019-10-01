using System;
using Aula11_1Poo_Heranças.Models;

namespace Aula11_1Poo_Heranças.Controllers
{
    public class CarrosController
    {
        CarroModel carro = new CarroModel();
        MotorModel Motor = new MotorModel();
        

        public void Ligar()
        {
            carro.Ligado = true;
            System.Console.WriteLine("Ligando o carro!");
        }
        public void Desligar()
        {
            carro.Ligado = false;
            System.Console.WriteLine("Desligando carro..");
        }
        public void Acelerar()
        {
            if(carro.Ligado == true)
            {
                System.Console.WriteLine("Vrummmmmmm");
            } else
            {
                System.Console.WriteLine("O carro não esta ligado! Impossível acelerar!");
            }
        }

        public void Frear()
        {
            if (carro.Ligado == true)
            {
                System.Console.WriteLine("Carro freando...");
            } else{
                System.Console.WriteLine("O carro não esta ligado");
            }
        }
        public void CadastrarMotor()
        {
            System.Console.WriteLine("Insira quantos cavalos tem o motor: ");
            Motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira a quantidade de cilindros do motor");
            Motor.Cilindro = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o modelo do pistão do motor");
            Motor.Pistao = Console.ReadLine();

            
        }
    }
}