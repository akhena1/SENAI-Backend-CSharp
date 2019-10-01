using ex2.Models;
namespace ex2.Controllers
{
    public class CelularController
    {
        CelularModel c1 = new CelularModel();
        public void Ligar()
        {
            System.Console.WriteLine("Celular ligando...");
            c1.Tela = true;
        }
        public void Desligar()
        {
            System.Console.WriteLine("Desligando...");
            c1.Tela = false;
        }
        public void EnviarMensagem()
        {
            if(c1.Tela == true)
            {
                System.Console.WriteLine("Mensagem enviada!");
            }
            else{
                System.Console.WriteLine("Mandando mensagem com o celular desligado cara.... é por pessoas como você que tem instrução na caixa de leite");
            }
        }
        public void FazerLigacao()
        {
            if(c1.Tela == true)
            {
                System.Console.WriteLine("Ligando... piii.... pii...");
            }
            else{
                System.Console.WriteLine("Eu não sei exatamente como você vai ler essa mensagem de erro com o celular desligado mas.... seu celular ta desligado ok");
            }
        }
    }
}