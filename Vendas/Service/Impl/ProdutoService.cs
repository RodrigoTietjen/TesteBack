

using AutoMapper;
using EFGetStarted.AspNetCore.NewDb.Models;
using System.Collections.Generic;
using System.Linq;
using Vendas.DTO;
using Vendas.Domain;

namespace Vendas.Service.Impl
{
    public class ProdutoService : IProdutoService
    {
        private readonly ContextoBanco _context;

        private IMapper _mapper;

        public ProdutoService(
            ContextoBanco context,
            IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }
        public ProdutoDTO update(ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);
            _context.Update(produto);
            _context.SaveChangesAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public ProdutoDTO getOne(long Id)
        {
            Produto result = _context.Produtos
                .FirstOrDefault(m => m.ProdutoId == Id);
            return _mapper.Map<ProdutoDTO>(result);
        }

        public ICollection<ProdutoDTO> getAll()
        {
            List<Produto> result = _context.Produtos.ToList();
            return _mapper.Map<List<ProdutoDTO>>(result);
        }

        public ProdutoDTO create(ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);

            _context.Add(produto);
            _context.SaveChangesAsync();

            return produtoDTO;
        }

        public void delete(long id)
        {
            Produto produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChangesAsync();
            }
        }
    }
}
