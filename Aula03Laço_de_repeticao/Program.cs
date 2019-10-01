using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            /*  //Laço contado - For - incremento (+)

            for (int cont = 1; cont <= 100; cont++) {

                //Verificamos se o número é diferente de par 

                if (cont % 2 != 0) {
                    Console.WriteLine ("For 0-100 - " + cont);
                }
            }
            // Laço contado - for - decremento (-)

            for (int cont = 100; cont >= 0; cont--) {
                if (cont % 2 != 0) {
                    Console.WriteLine ("For 100-0 - " + cont);
                }
            }  */
            
            
            
            
            //Laço condicional - While

            
            
            
            
            
            
            
            double acumuladora = 0;
            double nota        = 0;
            int cont           = 0;
            string sair        = "";

            while(sair !="sim"){
                
                Console.Write("Digite a nota de um aluno:  ");
                nota = double.Parse(Console.ReadLine() );

        
                acumuladora += nota;
                cont++;

                Console.Write("Deseja sair da aplicação? sim/não ");
                sair = Console.ReadLine().ToLower();

                

            }

            Console.WriteLine("Média das notas : "+ (acumuladora/cont) );


            do{

            }while(  );



        }

    }
}
