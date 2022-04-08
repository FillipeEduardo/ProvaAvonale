using Microsoft.AspNetCore.Mvc;
using ProvaAvonale.Data;
using ProvaAvonale.Models;

namespace ProvaAvonale.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        [HttpPost("produtos")]
        public async Task<IActionResult> Post([FromBody] Estoque estoque, [FromServices] AppDbContext context)
        {
            if (estoque == null || estoque.ValorUnitario.GetType() != typeof(double) || estoque.QuantidadeEstoque.GetType() != typeof(int) || estoque.NomeProduto.GetType() != typeof(string))
            {
                return StatusCode(412, "Os valores informados não são válidos");
            }
            try
            {
                await context.Estoques.AddAsync(estoque);
                await context.SaveChangesAsync();
                return Ok("Produto Cadastrado");
            }
            catch (Exception)
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }
        
    }
}