using Aula11_1Poo_Heranças.Models;

namespace Aula11_1Poo_Heranças.Controllers
{
    public class CarrosEletricosControllers : CarrosController
    {
        //Declarando objeto CarroEletricoModedl
        CarroEletricoModel CarroEletrico = new CarroEletricoModel();
        //Declarando objeto MotorModel
        MotorModel motor = new MotorModel();

        public void CarregarBateria(float carga)
        {
            if(CarroEletrico.Bateria <100)
            {
                CarroEletrico.Bateria += carga;
                //CarroEletrico.Bateria = CarroEletrico.Bateria + carga;
            }else
            {
                System.Console.WriteLine("A bateria do carro já está completa! Pode viajar!");
            }
        }
        public float StatusBateria()
        {
            return CarroEletrico.Bateria;
        }
    }
}