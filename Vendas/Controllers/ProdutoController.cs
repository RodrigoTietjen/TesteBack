using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vendas.DTO;
using Vendas.Service;

namespace Vendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public ActionResult<List<ProdutoDTO>> getTodos()
        {
            return Ok(_produtoService.getAll());
        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoDTO> getOne(long id)
        {
            ProdutoDTO produtoDTO = _produtoService.getOne(id);
            if (produtoDTO == null)
            {
                return NotFound("Nenhum Produto encontrado");
            }
            return Ok(produtoDTO);
        }

        [HttpPost]
        public ActionResult<ProdutoDTO> create([FromBody] ProdutoDTO dto)
        {
            ProdutoDTO result = _produtoService.create(dto);
            return Ok(result);
        }


        [HttpPut]
        public ActionResult<ProdutoDTO> update([FromBody] ProdutoDTO dto)
        {
            ProdutoDTO result = _produtoService.update(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<long> delete(long id)
        {
            _produtoService.delete(id);
            return Ok(id);
        }

    }
}
