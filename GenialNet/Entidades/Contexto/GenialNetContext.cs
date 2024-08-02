using GenialNet.Configurations;
using GenialNet.Entidades.Enumeradores;
using Microsoft.EntityFrameworkCore;

namespace GenialNet.Entidades.Contexto;

public class GenialNetContext : DbContext
{
	public GenialNetContext(DbContextOptions options) : base(options)
	{
		
	}   

	public DbSet<Produto> Produtos { get; set; }
	public DbSet<Fornecedor> Fornecedores { get; set; }
	public DbSet<Endereco> Enderecos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
        modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

        modelBuilder.Entity<Fornecedor>().HasData(
            new Fornecedor { Id = 1, Nome = "Fornecedor A", CNPJ = "12345678000195", Telefone = "(11) 1234-5678", DataCriacao = DateTime.UtcNow },
            new Fornecedor { Id = 2, Nome = "Fornecedor B", CNPJ = "23456789000196", Telefone = "(21) 2345-6789", DataCriacao = DateTime.UtcNow },
            new Fornecedor { Id = 3, Nome = "Fornecedor C", CNPJ = "34567890000197", Telefone = "(31) 3456-7890", DataCriacao = DateTime.UtcNow },
            new Fornecedor { Id = 4, Nome = "Fornecedor D", CNPJ = "45678901000198", Telefone = "(41) 4567-8901", DataCriacao = DateTime.UtcNow },
            new Fornecedor { Id = 5, Nome = "Fornecedor E", CNPJ = "56789012000199", Telefone = "(51) 5678-9012", DataCriacao = DateTime.UtcNow }
        );

        modelBuilder.Entity<Produto>().HasData(
            new Produto { Id = 1, Descricao = "Produto X", Marca = "Marca X", UnidadeMedida = UnidadeMedida.Unidade, Valor = 10.00m, FornecedorId = 1 },
            new Produto { Id = 2, Descricao = "Produto Y", Marca = "Marca Y", UnidadeMedida = UnidadeMedida.Unidade, Valor = 20.00m, FornecedorId = 2 },
            new Produto { Id = 3, Descricao = "Produto Z", Marca = "Marca Z", UnidadeMedida = UnidadeMedida.Unidade, Valor = 30.00m, FornecedorId = 3 },
            new Produto { Id = 4, Descricao = "Produto W", Marca = "Marca W", UnidadeMedida = UnidadeMedida.Unidade, Valor = 40.00m, FornecedorId = 4 },
            new Produto { Id = 5, Descricao = "Produto V", Marca = "Marca V", UnidadeMedida = UnidadeMedida.Unidade, Valor = 50.00m, FornecedorId = 5 }
        );

        modelBuilder.Entity<Endereco>().HasData(
            new Endereco { Id = 1, Cep = "01001000", Logradouro = "Rua A", Complemento = "Apto 101", Unidade = "1", Bairro = "Centro", Localidade = "São Paulo", Uf = "SP", Ibge = "3550308", Gia = "0001", Ddd = "11", Siafi = "1234", FornecedorId = 1 },
            new Endereco { Id = 2, Cep = "02002000", Logradouro = "Rua B", Complemento = "Apto 202", Unidade = "2", Bairro = "Jardim", Localidade = "São Paulo", Uf = "SP", Ibge = "3550308", Gia = "0002", Ddd = "11", Siafi = "2345", FornecedorId = 2 },
            new Endereco { Id = 3, Cep = "03003000", Logradouro = "Rua C", Complemento = "Apto 303", Unidade = "3", Bairro = "Vila", Localidade = "São Paulo", Uf = "SP", Ibge = "3550308", Gia = "0003", Ddd = "11", Siafi = "3456", FornecedorId = 3 },
            new Endereco { Id = 4, Cep = "04004000", Logradouro = "Rua D", Complemento = "Apto 404", Unidade = "4", Bairro = "Bela Vista", Localidade = "São Paulo", Uf = "SP", Ibge = "3550308", Gia = "0004", Ddd = "11", Siafi = "4567", FornecedorId = 4 },
            new Endereco { Id = 5, Cep = "05005000", Logradouro = "Rua E", Complemento = "Apto 505", Unidade = "5", Bairro = "Perdizes", Localidade = "São Paulo", Uf = "SP", Ibge = "3550308", Gia = "0005", Ddd = "11", Siafi = "5678", FornecedorId = 5 }
        );
    }
}