using Aula13_tarde.Models;

namespace Aula13_tarde.Controllers
{
    public class CapitaoAmericaController
    {
        CapitaoAmericaModel Cap = new CapitaoAmericaModel();
        HomemDeFerroModel Man = new HomemDeFerroModel();

        public void Pular ()
        {
            
            System.Console.WriteLine("Cap Pulando...");
        }
        public void Lançar (int vida, int dano){
            System.Console.WriteLine("Lançando exxxcudo");
                vida = vida - dano;
            
        }
        public void Defesa ()
        {

            Cap.Vida = Cap.Vida + 5;
            System.Console.WriteLine("Capitão curou 5!");

        }

    }
}