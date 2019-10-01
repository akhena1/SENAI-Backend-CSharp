namespace ex1.Models
{
    public class AlunoModel
    {
        public string Nome { get ; set ;}
        public string Curso { get ; set ;}
        public int Idade { get; set; }
        public string Rg { get; set; }

        //String usada para validar a variável booleana
        public string ValidacaoBolsista{ get; set; }
        public bool Bolsista { get; set; }

    }
}