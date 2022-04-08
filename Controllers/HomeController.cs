using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            if (estoque == null || estoque.ValorUnitario == 0 || estoque.QuantidadeEstoque == 0)
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
        [HttpGet("produtos")]
        public async Task<IActionResult> Get([FromServices] AppDbContext context)
        {
            try
            {
                var lista = await context.Estoques.ToListAsync();
                return Ok(lista);
            }
            catch (Exception)
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }
        
    }
}