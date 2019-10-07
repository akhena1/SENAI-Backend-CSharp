namespace ex1.Models
{
    public class AlunoModel
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Rg { get; set; }
        public int Idade { get; set; }
        public bool Bolsista { get; set; }

        public AlunoModel(string nome, string curso, string rg, int idade, bool bolsista)
        {
            this.Nome = nome;
            this.Curso = curso;
            this.Rg = rg;
            this.Idade = idade;
            this.Bolsista = bolsista;

        }
        public AlunoModel()
        {
            
        }
    }
}