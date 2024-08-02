using GenialNet.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenialNet.Configurations;

public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produtos");

        builder.HasKey(c => c.Id);

        builder.Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Marca)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.UnidadeMedida)
            .IsRequired();

        builder.Property(p => p.Valor)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.DataCriacao)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd();

        builder.Property(p => p.DataAlteracao)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAddOrUpdate();
    }
}