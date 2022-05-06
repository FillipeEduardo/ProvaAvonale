using System.Text.Json.Serialization;

namespace ProvaAvonale.Models
{
    public class Cartao
    {
        [JsonPropertyName("titular")]
        public string Titular { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("data_expiracao")]
        public string DataExpiracao { get; set; }

        [JsonPropertyName("bandeira")]
        public string Bandeira { get; set; }

        [JsonPropertyName("cvv")]
        public string Cvv { get; set; }
    }
}



