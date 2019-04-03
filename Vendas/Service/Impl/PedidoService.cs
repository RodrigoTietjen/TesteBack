

using AutoMapper;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Vendas.DTO;
using Vendas.Domain;

namespace Vendas.Service.Impl
{
    public class PedidoService : IPedidoService
    {
        private readonly ContextoBanco _context;

        private IMapper _mapper;

        public PedidoService(
            ContextoBanco context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }
        public PedidoDTO update(PedidoDTO pedido)
        {
            _context.Update(pedido);
            _context.SaveChangesAsync();
            return pedido;
        }

        public PedidoDTO getOne(long Id)
        {
            Pedido result = _context.Pedidos
    .FirstOrDefault(m => m.PedidoId == Id);
            return _mapper.Map<PedidoDTO>(result);
        }

        public List<PedidoDTO> getAll()
        {
            List<Pedido> result = _context.Pedidos
                .Include(pedido => pedido.Produtos)
                    .ThenInclude(pedidoProduto => pedidoProduto.Produto).ToList();
            return _mapper.Map<List<PedidoDTO>>(result);
        }

        public PedidoDTO create(PedidoDTO pedidoDTO)
        {
            Pedido pedido = _mapper.Map<Pedido>(pedidoDTO);

            foreach(ProdutoPedido produto in pedido.Produtos) {
                produto.Produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == produto.ProdutoId);
            }

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return _mapper.Map<PedidoDTO>(_context.Pedidos.Last());
        }

        public void delete(long id)
        {
            Pedido pedido = _context.Pedidos.Find(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChangesAsync();
            }
        }
    }
}
