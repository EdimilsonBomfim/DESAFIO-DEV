using System;
using CPT.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CPT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServices _produtoServices;        

        public ProdutoController(IProdutoServices produtoServices)
        {
            _produtoServices = produtoServices;
        }

        [HttpGet]         
        public IActionResult GetAll()
        {
            try
            {
                var result = _produtoServices.GetAll();

                if (result is null)
                    return NoContent();

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro ao processar a requisição: {e.Message}");
            }
        }

        [HttpGet]
        [Route("nome/{nome}")]
        public IActionResult GetByName(string nome)
        {
            try
            {
                var result = _produtoServices.GetByName(nome);

                if (result is null)
                    return NoContent();

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro ao processar a requisição: {e.Message}");
            }
        }
    }
}