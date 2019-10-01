using System;

namespace ex5.Models
{
    public class PedidoModel : PizzaModel
    {
        public DateTime DataPedido{ get; set; }
        public string EnderecoEntrega{ get; set; }
        public DateTime PrevisaoEntrega{get; set; }
        
        

    }
}