namespace Vendas.DTO
{
    public class ProdutoDTO
    {
        public long ProdutoId { set; get; }
        
        public string Nome { set; get; }
        
        public string Descricao { set; get; }
        
        public decimal CustoCompra { set; get; }

        public string Foto { set; get; }
    }
}
