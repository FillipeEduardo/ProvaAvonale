
using System.Text.Json.Serialization;

namespace ProvaAvonale.Models
{
    public class PagamentoModel
    {


        [JsonPropertyName("valor")]
        public double Valor { get; set; }

        [JsonPropertyName("cartao")]
        public CartaoModel? Cartao { get; set; }

        public PagamentoModel(double valor, CartaoModel? cartao)
        {
            Valor = valor;
            Cartao = cartao;
        }
    }
}

