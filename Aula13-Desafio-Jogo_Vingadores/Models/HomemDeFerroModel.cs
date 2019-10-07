using System;

namespace Aula13_tarde.Models
{
    public class HomemDeFerroModel 
    {
        public int Vida {get; set;}
        public int Armadura {get; set;} = 10;
        public bool ArmaduraValid {get; set;}
        public void CorText2 ()
      {
        Console.ForegroundColor = ConsoleColor.Red;
      }
    }
}