using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProvaAvonale.Models
{
    public class ProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string? NomeProduto { get; set; }
        [JsonPropertyName("valor_unitario")]
        [Required(ErrorMessage = "O valor unitário é obrigatório.")]
        public double ValorUnitario { get; set; }
        [JsonPropertyName("qtde_estoque")]
        [Required(ErrorMessage = "A quantidade do estoque é obrigatória.")]
        public int QuantidadeEstoque { get; set; }
        public DateTime DataUltimaVenda { get; set; }
        public double ValorUltimaVenda { get; set; }
    }
}