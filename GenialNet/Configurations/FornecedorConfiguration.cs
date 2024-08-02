using GenialNet.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenialNet.Configurations;

public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
{
    public void Configure(EntityTypeBuilder<Fornecedor> builder)
    {
        builder.ToTable("Fornecedores");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Nome)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.CNPJ)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(e => e.Telefone)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(e => e.DataCriacao)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd();

        builder.Property(e => e.DataAlteracao)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAddOrUpdate();

        builder.HasMany(e => e.Produtos)
            .WithOne()
            .HasForeignKey(p => p.FornecedorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Endereco)
            .WithOne(e => e.Fornecedor)
            .HasForeignKey<Endereco>(e => e.FornecedorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}