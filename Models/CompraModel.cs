using System.Text.Json.Serialization;

namespace ProvaAvonale.Models
{
    public class CompraModel
    {
        [JsonPropertyName("produto_id")]
        public int ProdutoId { get; set; }

        [JsonPropertyName("qtde_comprada")]
        public int QtdeComprada { get; set; }

        [JsonPropertyName("cartao")]
        public CartaoModel? Cartao { get; set; }
    }
}