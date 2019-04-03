using System.ComponentModel.DataAnnotations;

namespace Vendas.Domain
{
    public class Produto
    {
        public long ProdutoId { set; get; }
        
        public string Nome { set; get; }
        
        public string Descricao { set; get; }
        
        public decimal CustoCompra { set; get; }

        [StringLength(maximumLength: 2147483645)]
        public string Foto { set; get; }
    }
}
