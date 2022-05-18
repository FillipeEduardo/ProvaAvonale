using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaAvonale.Data;
using ProvaAvonale.Models;

namespace ProvaAvonale.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProdutoController : ControllerBase
    {
        readonly AppDbContext _context = new();

        [HttpPost("produtos")]
        public async Task<IActionResult> Post([FromBody] ProdutoModel estoque)
        {
            if (estoque.ValorUnitario == 0 || estoque.QuantidadeEstoque == 0)
            {
                return StatusCode(412, "Os valores informados não são válidos");
            }
            try
            {
                if (_context.Produtos != null) await _context.Produtos.AddAsync(estoque);
                await _context.SaveChangesAsync();
                return Ok("Produto Cadastrado");
            }
            catch
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }
        [HttpGet("produtos")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var lista = await _context.Produtos!.ToListAsync();
                return Ok(lista);
            }
            catch
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }
        [HttpGet("produtos/{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {

            try
            {
                var model = await _context.Produtos!.FirstOrDefaultAsync(x => x.Id == id);
                if (model == null) return BadRequest("Ocorreu um erro desconhecido");
                return Ok(model);
            }
            catch
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }
        [HttpDelete("produtos/{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var model = await _context.Produtos!.FirstOrDefaultAsync(x => x.Id == id);
                if (model == null) return BadRequest("Ocorreu um erro desconhecido");
                _context.Produtos!.Remove(model);
                await _context.SaveChangesAsync();
                return Ok("Produto excluído com sucesso");
            }
            catch
            {
                return StatusCode(400, "Ocorreu um erro desconhecido");
            }
        }
        
    }
}