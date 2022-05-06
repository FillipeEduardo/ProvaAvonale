using ProvaAvonale.Models;
using ProvaAvonale.Results;
using Refit;
using Microsoft.AspNetCore.Mvc;

namespace ProvaAvonale.Repositories.Interfaces
{
    public interface IPagamentoRepository
    {
        [Post("/api/gateways/compras")]
        Task<Result> PostPagamento(PagamentoModel pagamento);
    }
}