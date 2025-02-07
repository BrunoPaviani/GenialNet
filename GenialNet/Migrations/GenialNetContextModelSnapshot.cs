﻿// <auto-generated />
using System;
using GenialNet.Entidades.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenialNet.Migrations
{
    [DbContext(typeof(GenialNetContext))]
    partial class GenialNetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenialNet.Entidades.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DataAlteracao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<long>("FornecedorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Gia")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Ibge")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Siafi")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("Enderecos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Bairro = "Centro",
                            Cep = "01001000",
                            Complemento = "Apto 101",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ddd = "11",
                            FornecedorId = 1L,
                            Gia = "0001",
                            Ibge = "3550308",
                            Localidade = "São Paulo",
                            Logradouro = "Rua A",
                            Siafi = "1234",
                            Uf = "SP",
                            Unidade = "1"
                        },
                        new
                        {
                            Id = 2L,
                            Bairro = "Jardim",
                            Cep = "02002000",
                            Complemento = "Apto 202",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ddd = "11",
                            FornecedorId = 2L,
                            Gia = "0002",
                            Ibge = "3550308",
                            Localidade = "São Paulo",
                            Logradouro = "Rua B",
                            Siafi = "2345",
                            Uf = "SP",
                            Unidade = "2"
                        },
                        new
                        {
                            Id = 3L,
                            Bairro = "Vila",
                            Cep = "03003000",
                            Complemento = "Apto 303",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ddd = "11",
                            FornecedorId = 3L,
                            Gia = "0003",
                            Ibge = "3550308",
                            Localidade = "São Paulo",
                            Logradouro = "Rua C",
                            Siafi = "3456",
                            Uf = "SP",
                            Unidade = "3"
                        },
                        new
                        {
                            Id = 4L,
                            Bairro = "Bela Vista",
                            Cep = "04004000",
                            Complemento = "Apto 404",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ddd = "11",
                            FornecedorId = 4L,
                            Gia = "0004",
                            Ibge = "3550308",
                            Localidade = "São Paulo",
                            Logradouro = "Rua D",
                            Siafi = "4567",
                            Uf = "SP",
                            Unidade = "4"
                        },
                        new
                        {
                            Id = 5L,
                            Bairro = "Perdizes",
                            Cep = "05005000",
                            Complemento = "Apto 505",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ddd = "11",
                            FornecedorId = 5L,
                            Gia = "0005",
                            Ibge = "3550308",
                            Localidade = "São Paulo",
                            Logradouro = "Rua E",
                            Siafi = "5678",
                            Uf = "SP",
                            Unidade = "5"
                        });
                });

            modelBuilder.Entity("GenialNet.Entidades.Fornecedor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("DataAlteracao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CNPJ = "12345678000195",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5442),
                            Nome = "Fornecedor A",
                            Telefone = "(11) 1234-5678"
                        },
                        new
                        {
                            Id = 2L,
                            CNPJ = "23456789000196",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5444),
                            Nome = "Fornecedor B",
                            Telefone = "(21) 2345-6789"
                        },
                        new
                        {
                            Id = 3L,
                            CNPJ = "34567890000197",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5446),
                            Nome = "Fornecedor C",
                            Telefone = "(31) 3456-7890"
                        },
                        new
                        {
                            Id = 4L,
                            CNPJ = "45678901000198",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5447),
                            Nome = "Fornecedor D",
                            Telefone = "(41) 4567-8901"
                        },
                        new
                        {
                            Id = 5L,
                            CNPJ = "56789012000199",
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2024, 8, 2, 14, 52, 11, 714, DateTimeKind.Utc).AddTicks(5449),
                            Nome = "Fornecedor E",
                            Telefone = "(51) 5678-9012"
                        });
                });

            modelBuilder.Entity("GenialNet.Entidades.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataAlteracao")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("FornecedorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Produto X",
                            FornecedorId = 1L,
                            Marca = "Marca X",
                            UnidadeMedida = 1,
                            Valor = 10.00m
                        },
                        new
                        {
                            Id = 2L,
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Produto Y",
                            FornecedorId = 2L,
                            Marca = "Marca Y",
                            UnidadeMedida = 1,
                            Valor = 20.00m
                        },
                        new
                        {
                            Id = 3L,
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Produto Z",
                            FornecedorId = 3L,
                            Marca = "Marca Z",
                            UnidadeMedida = 1,
                            Valor = 30.00m
                        },
                        new
                        {
                            Id = 4L,
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Produto W",
                            FornecedorId = 4L,
                            Marca = "Marca W",
                            UnidadeMedida = 1,
                            Valor = 40.00m
                        },
                        new
                        {
                            Id = 5L,
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Produto V",
                            FornecedorId = 5L,
                            Marca = "Marca V",
                            UnidadeMedida = 1,
                            Valor = 50.00m
                        });
                });

            modelBuilder.Entity("GenialNet.Entidades.Endereco", b =>
                {
                    b.HasOne("GenialNet.Entidades.Fornecedor", "Fornecedor")
                        .WithOne("Endereco")
                        .HasForeignKey("GenialNet.Entidades.Endereco", "FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GenialNet.Entidades.Produto", b =>
                {
                    b.HasOne("GenialNet.Entidades.Fornecedor", null)
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenialNet.Entidades.Fornecedor", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
