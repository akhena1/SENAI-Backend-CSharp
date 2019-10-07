using System;
using System.Collections.Generic;
using ex1.Models;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AlunoModel> a1 = new List<AlunoModel>();

            a1.Add(new AlunoModel("Gustavo","CodeXP","29.435.332-1",19,true));
            a1.Add(new AlunoModel("Miguel","CodeXP","21.445.632-7",24,true));
            a1.Add(new AlunoModel("Bruno","CodeXP","20.035.302-2",17,true));
            a1.Add(new AlunoModel("Larissa","CodeXP","09.135.342-3",19,true));
            a1.Add(new AlunoModel("Gabriela","CodeXP","50.905.132-4",19,true));
            a1.Add(new AlunoModel("Isabella","CodeXP","56.201.485-9",19,true));

            foreach(AlunoModel a in a1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Nome: "+a.Nome);
                System.Console.WriteLine("Curso: "+a.Curso);
                System.Console.WriteLine("RG: "+a.Rg);
                System.Console.WriteLine("Idade: "+a.Idade);
                System.Console.WriteLine("Bolsista: "+a.Bolsista);
            }
        }
    }
}
