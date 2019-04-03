
using System.Collections.Generic;
using Vendas.DTO;

namespace Vendas.Service
{
    public interface IProdutoService
    {
        ICollection<ProdutoDTO> getAll();

        ProdutoDTO getOne(long id);

        ProdutoDTO create(ProdutoDTO pedidoDTO);

        ProdutoDTO update(ProdutoDTO pedidoDTO);

        void delete(long id);
    }
}
