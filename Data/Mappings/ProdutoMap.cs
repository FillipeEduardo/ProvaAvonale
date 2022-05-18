using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaAvonale.Models;

namespace ProvaAvonale.Data.Mappings;

public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
{
    public void Configure(EntityTypeBuilder<ProdutoModel> builder)
    {
        builder.ToTable("Produto");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.NomeProduto)
            .IsRequired()
            .HasColumnName("Nome")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.QuantidadeEstoque)
            .IsRequired()
            .HasColumnName("Quantidade")
            .HasColumnType("INTEGER");

        builder.Property(x => x.ValorUnitario)
            .IsRequired()
            .HasColumnName("ValorUnitario")
            .HasColumnType("DOUBLE");

        builder.Property(x => x.DataUltimaVenda)
            .HasColumnName("DataUltimaVenda")
            .HasColumnType("DATETIME");

        builder.Property(x => x.ValorUltimaVenda)
            .HasColumnName("ValorUltimaVenda")
            .HasColumnType("DOUBLE");
    }
}