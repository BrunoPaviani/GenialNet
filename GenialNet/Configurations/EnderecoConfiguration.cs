using GenialNet.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenialNet.Configurations;

public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("Enderecos");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Cep)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(e => e.Logradouro)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Complemento)
            .HasMaxLength(50);

        builder.Property(e => e.Unidade)
            .HasMaxLength(10);

        builder.Property(e => e.Bairro)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.Localidade)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.Uf)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(e => e.Ibge)
            .HasMaxLength(7);

        builder.Property(e => e.Gia)
            .HasMaxLength(5);

        builder.Property(e => e.Ddd)
            .HasMaxLength(2);

        builder.Property(e => e.Siafi)
            .HasMaxLength(6);

        builder.Property(e => e.DataCriacao)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd();

        builder.Property(e => e.DataAlteracao)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAddOrUpdate();

        builder.HasOne(e => e.Fornecedor)
            .WithOne(f => f.Endereco)
            .HasForeignKey<Endereco>(e => e.FornecedorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}