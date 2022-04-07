using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaAvonale.Models
{
    public class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public DateTime DataUltimaVenda { get; set; }
        public double ValorUltimaVenda { get; set; }
    }
}