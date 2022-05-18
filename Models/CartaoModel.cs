using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProvaAvonale.Models
{
    public class CartaoModel
    {
        [JsonPropertyName("titular")]
        [Required]
        public string? Titular { get; set; }
        
        [CreditCard]
        [JsonPropertyName("numero")]
        [Required]
        public string? Numero { get; set; }

        [JsonPropertyName("data_expiracao")]
        [Required]
        public string? DataExpiracao { get; set; }

        [JsonPropertyName("bandeira")]
        [Required]
        public string? Bandeira { get; set; }

        [JsonPropertyName("cvv")]
        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        public string? Cvv { get; set; }
    }
}



