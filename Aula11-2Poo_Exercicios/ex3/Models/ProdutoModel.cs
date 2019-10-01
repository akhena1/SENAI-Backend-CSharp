namespace ex3.Models
{
    public class ProdutoModel
    {
        public string IdProduto { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }

        
        public bool Reserva{ get; set; }

        //Mesma lógica do exercício anterior
        public string ReservaValidator{ get; set;}

    }
}