using ProvaAvonale.Models;
using ProvaAvonale.Results;
using Refit;

namespace ProvaAvonale.Repositories.Interfaces
{
    public interface IPagamentoRepository
    {
        [Post("/api/gateways/compras")]
        Task<Result> PostPagamento(PagamentoModel pagamento);

    }
}