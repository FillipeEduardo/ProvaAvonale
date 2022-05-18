using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaAvonale.Data;
using ProvaAvonale.Models;
using ProvaAvonale.Repositories.Interfaces;

namespace ProvaAvonale.Controllers
{
    [ApiController]
    [Route("api/compras")]
    public class CompraController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostCompra([FromBody] CompraModel compra, [FromServices] AppDbContext context, [FromServices] IPagamentoRepository repository)
        {
            try
            {
                var produto = await context.Produtos!.FirstOrDefaultAsync(x => x.Id == compra.ProdutoId);
                var pagamento = new PagamentoController();
                var valor = compra.QtdeComprada * produto!.ValorUnitario;
                var pagamentoModel = new PagamentoModel(valor, compra.Cartao);
                
                var retorno = await pagamento.PostPagamento(repository, pagamentoModel);
                if (retorno.Estado == "APROVADO" && produto.QuantidadeEstoque >= compra.QtdeComprada)
                {
                    produto.QuantidadeEstoque -= compra.QtdeComprada;
                }
                return Ok("Venda realizada com sucesso");
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro desconhecido");
            }
        }




    }
}