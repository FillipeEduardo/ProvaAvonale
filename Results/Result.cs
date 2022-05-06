using System.Text.Json.Serialization;

namespace ProvaAvonale.Results
{
    public struct Result
    {
        [JsonPropertyName("valor")]
        public double Valor { get; set; }

        [JsonPropertyName("estado")]
        public string Estado { get; set; }
    }
}