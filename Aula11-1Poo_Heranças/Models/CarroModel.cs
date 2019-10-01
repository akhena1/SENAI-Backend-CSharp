namespace Aula11_1Poo_Heranças.Models
{
    public class CarroModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string cor { get; set;}
        public string Placa { get; set; }
        public bool Ligado { get; set; }
        public MotorModel Motor{ get; set; }


    }
}