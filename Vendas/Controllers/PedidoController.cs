using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vendas.DTO;
using Vendas.Service;

namespace Vendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        
        public ActionResult<List<PedidoDTO>> getTodos()
        {
            return Ok(_pedidoService.getAll());
        }
        
        [HttpGet("{id}")]
        public ActionResult<PedidoDTO> getOne(long id)
        {
            PedidoDTO pedidoDTO = _pedidoService.getOne(id);
            if (pedidoDTO == null)
            {
                return NotFound("Nenhum Pedido encontrado");
            }
            return Ok(pedidoDTO);
        }

        [HttpPost]
        public ActionResult<PedidoDTO> create([FromBody] PedidoDTO dto)
        {
            PedidoDTO result = _pedidoService.create(dto);
            return Ok(result);
        }


        [HttpPut]
        public ActionResult<PedidoDTO> update([FromBody] PedidoDTO dto)
        {
            PedidoDTO result = _pedidoService.update(dto);
            return Ok(result);
        }

        [HttpDelete]
        public ActionResult<long> delete(long id)
        {
            _pedidoService.delete(id);
            return Ok(id);
        }

    }
}
