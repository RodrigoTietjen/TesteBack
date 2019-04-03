using Vendas.Domain;

namespace Vendas.DTO
{
    public class ProdutoPedidoDTO
    {
        public long ProdutoPedidoId { get; set; }

        public Produto Produto { get; set; }

        public long ProdutoId { get; set; }

        public long PedidoId { get; set; }

        public decimal PrecoVenda { get; set; }

        public long Quantidade { get; set; }
    }
}
