using System;

namespace Aula13_tarde.Models
{
    public class CapitaoAmericaModel
    {
      public int Vida {get; set;}
      public int Escudo {get; set;} = 10;
      public bool EscudoValid {get; set;}
      public void CorText1 ()
      {
        Console.ForegroundColor = ConsoleColor.Blue;
      }
    }
}