using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine() );

            if ( idade >= 18 ){

                Console.WriteLine("É isso ai! Você pode jogar o que quiser.");
            }
            else{
                if( idade >= 17){
                    
                    Console.WriteLine("Você pode jogar quase tudo! Menos os jogos classificados apenas para adultos (Adults Only- AO) ");
                }
                else{
                    if( idade >= 13){
                       
                        Console.WriteLine( "Você não pode jogar games classificados em Mature(M) nem Adults Only(AO). Existe um mundo inteiro para explorar , tudo tem seu tempo jovem padawan." );
                    }
                    else{
                        if( idade >= 10 ){

                            Console.WriteLine("Você pode jogar games da categoria Everyone10+(E10+), Everyone(E) e Early Childhood(EC)");
                        }
                        else{
                            if( idade >= 6 ){
                                
                                Console.WriteLine("Você pode jogar games da categoria Everyone(E) e Early Childhood(EC)");
                            }
                            else{
                                Console.WriteLine(" É melhor ir brincar com carrinhos, mas caso queira jogar, você se encaixa na classificação Early Childhood ");
                            }
                        }
                    }
                }
            }
        }
    }
}
