using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sabore.BLL;
using Sabore.Models;

namespace Sabore.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        [HttpGet]
        public IActionResult GetProdutos()
        {
            var listaProdutos = _produtoService.ListarProdutos();
            return Ok(listaProdutos);
        }

        [HttpPost]
        public IActionResult CadastrarProduto([FromBody] Produto param)
        {
            var resut = _produtoService.CadastrarProduto(param);
            if (!resut)
                return BadRequest("Erro ao cadastrar produto");

            return Ok("Produto cadastrado com sucesso!");
        }
    }
}
