using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.DTO
{
    public class PedidoDTO
    {
        public long PedidoId { get; set; }
        
        public DateTime Data { get; set; }
        
        public decimal ValorTotal { get; set; }

        public decimal DespesasTotais { get; set; }

        public long MargemLucro { get; set; }

        public ICollection<ProdutoPedidoDTO> Produtos { get; set; }
    }
}
