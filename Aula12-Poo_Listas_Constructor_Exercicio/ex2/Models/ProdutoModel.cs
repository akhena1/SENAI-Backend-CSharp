namespace ex2.Models
{
    public class ProdutoModel
    {
        public string IdProduto { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }
        public bool Reserva { get; set; }

        public ProdutoModel(string idproduto, string modelo, string cor, double preco, bool reserva)
        {
            this.IdProduto = idproduto;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Preco = preco;
            this.Reserva = reserva;
        }
        public ProdutoModel()
        {
            
        }
    }
}