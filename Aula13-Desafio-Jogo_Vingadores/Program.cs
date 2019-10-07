using System;
using Aula13_tarde.Controllers;
using Aula13_tarde.Models;

namespace Aula13_tarde
{
    class Program
    {
        static void Main(string[] args)
        {
            CapitaoAmericaController cap = new CapitaoAmericaController();
            CapitaoAmericaModel capM = new CapitaoAmericaModel();
            HomemDeFerroController Man = new HomemDeFerroController();
            HomemDeFerroModel ManM = new HomemDeFerroModel();



            string sair = "";
            string botao = "";
            ManM.Vida = 100;
            capM.Vida = 100;
            string confirm;

            System.Console.WriteLine("Vingadores Fighting");
            System.Console.WriteLine();
            System.Console.WriteLine("Instruções\n\n Pressione Q para Pular\n W para atacar\n e E para defender.\nCada Player tem direito a um movimento. Insira  ok se você entendeu.");
            confirm = Console.ReadLine();
            

            System.Console.WriteLine("Escolha seu personagem\nPressione 1 para Capitão américa\nPressione 2 para Homem de Ferro\n Pressione 0 para sair do jogo");
            sair = Console.ReadLine();
            
            while(sair != "0")
            {
                System.Console.WriteLine("O jogo começou!");
                switch(sair)
                {
                    
                    case "1":
                        
                        while(ManM.Vida != 0 || capM.Vida != 0){

                            
                            System.Console.WriteLine("Round do capitão!");
                            capM.CorText1();
                            botao = Console.ReadLine();
                            
                            
                        
                            if(botao == "q")
                            {
                                cap.Pular();
                            }
                            else if(botao == "w")
                            {
                                cap.Lançar(ManM.Vida, capM.Escudo);
                                ManM.Vida += -capM.Escudo;
                                System.Console.WriteLine("Vida do Homem de Ferro: "+ManM.Vida);
                            }
                            else if(botao == "e")
                            {
                                cap.Defesa();
                                ManM.Vida += + 10;
                            }
                            
                            System.Console.WriteLine("Round do Homem de Ferro!");
                            ManM.CorText2();
                            botao = Console.ReadLine();

                            if(botao == "q")
                            {
                                Man.Pular();
                            }
                            else if(botao == "w")
                            {
                                Man.Atirar(capM.Vida, ManM.Armadura);
                                capM.Vida += - ManM.Armadura;
                                System.Console.WriteLine("Vida do Capitão América: "+capM.Vida);

                            }
                            else if( botao == "e")
                            {
                                Man.Voar();
                            }

                            if(ManM.Vida <= 0)
                            {
                                System.Console.WriteLine();
                                System.Console.WriteLine("O Capitão ganhou!");
                                sair = "0";
                            }
                            if(capM.Vida <= 0)
                            {
                                System.Console.WriteLine();
                                System.Console.WriteLine("O Homem de ferro ganhou!");
                                sair = "0";
                            }

                            
                            
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;

                        
                        break;
                        case "2":
                        
                        break;
                }
            }

        }
    }
}
