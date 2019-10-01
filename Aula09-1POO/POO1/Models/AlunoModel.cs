using System;

namespace POO1.Models
{
    public class AlunoModel
    {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome {get; set;}


        /// <summary>
        /// Nome do curso do aluno
        /// </summary>
        /// <value>string</value>
        public string Curso{get; set;}


        /// <summary>
        /// Número do RA
        /// </summary>
        /// <value>string</value>
        public string RA{get; set;}

        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int Idade{get; set;}

        /// <summary>
        /// O aluno começa a estudar
        /// </summary>
        /// 
         public void Estudar ()
        {
            Console.WriteLine("Estou estudando");
        }

        /// <summary>
        /// O aluno pede intervalo.
        /// </summary>
        public void PedirIntervalo()
        {
            Console.WriteLine("Pode fazer intervalo aeeee");
            Console.WriteLine("Eu quero caféééée´!");
        }


        /// <summary>
        /// O aluno pede ajuda.
        /// </summary>
        public void PedirAjuda()
        {
            Console.WriteLine("Fessor, me ajuda aqui por favor?");
        }

        
    }
}