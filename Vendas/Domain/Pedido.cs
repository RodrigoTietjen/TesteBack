using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Domain
{
    public class Pedido
    {
        public long PedidoId { get; set; }
        
        public DateTime Data { get; set; }
        
        public decimal ValorTotal { get; set; }

        public decimal DespesasTotais { get; set; }

        public long MargemLucro { get; set; }

        
        public ICollection<ProdutoPedido> Produtos { get; set; }
        
    }
}
