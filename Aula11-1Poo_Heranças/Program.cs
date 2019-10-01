using System;
using Aula11_1Poo_Heranças.Controllers;
using Aula11_1Poo_Heranças.Models;

namespace Aula11_1Poo_Heranças
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro = new CarrosController();
            CarrosEletricosControllers carroEletrico = new CarrosEletricosControllers();

            Console.Clear(); //Limpa a tela no terminal

            carro.Ligar();
            carro.Acelerar();

            carro.Frear();
            carro.Desligar();
            
            carro.CadastrarMotor();

            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Carga do carro: "+carroEletrico.StatusBateria());

            carroEletrico.StatusBateria();
        }
    }
}
