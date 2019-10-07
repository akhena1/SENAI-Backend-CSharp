using Aula13_tarde.Models;

namespace Aula13_tarde.Controllers
{
    public class HomemDeFerroController
    {
        HomemDeFerroModel Man = new HomemDeFerroModel();
        CapitaoAmericaModel Cap = new CapitaoAmericaModel();

        public void Pular(){
            System.Console.WriteLine("Istarqui pulando...");
        }
        public void Atirar(int vida, int dano){
            System.Console.WriteLine("Istarqui atirano");
            vida = vida - dano;
            
        }
        public void Voar (){
            
            Man.Vida = Man.Vida +5; 
            System.Console.WriteLine("Homem de ferro curou 5!");

        }

        
    }
}