using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Domain
{
    public class ProdutoPedido
    {
        public long ProdutoPedidoId { get; set; }
        
        public Produto Produto { get; set; }

        [ForeignKey("Produto")]
        public long ProdutoId { get; set; }

        public long PedidoId { get; set; }

        public decimal PrecoVenda { get; set; }

        public long Quantidade { get; set; }
    }
}
