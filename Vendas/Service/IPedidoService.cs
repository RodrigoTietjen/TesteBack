
using System.Collections.Generic;
using Vendas.DTO;

namespace Vendas.Service
{
    public interface IPedidoService
    {
        List<PedidoDTO> getAll();

        PedidoDTO getOne(long id);

        PedidoDTO create(PedidoDTO pedidoDTO);

        PedidoDTO update(PedidoDTO pedidoDTO);

        void delete(long id);
    }
}
