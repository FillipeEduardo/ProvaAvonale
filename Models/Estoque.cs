using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProvaAvonale.Models
{
    public class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string NomeProduto { get; set; }
        [JsonPropertyName("valor_unitario")]
        public double ValorUnitario { get; set; }
        [JsonPropertyName("qtde_estoque")]
        public int QuantidadeEstoque { get; set; }
        public DateTime DataUltimaVenda { get; set; }
        public double ValorUltimaVenda { get; set; }
    }
}