using Microsoft.AspNetCore.Mvc;
using ProvaAvonale.Models;
using ProvaAvonale.Repositories.Interfaces;
using ProvaAvonale.Results;

namespace ProvaAvonale.Controllers
{
    [ApiController]
    [Route("api/pagamento/compras")]
    public class PagamentoController : ControllerBase
    {
        [HttpPost]
        public Task<Result> PostPagamento([FromServices] IPagamentoRepository repository, [FromBody] PagamentoModel pagamento)
        {
            return repository.PostPagamento(pagamento);
        }
    }
}