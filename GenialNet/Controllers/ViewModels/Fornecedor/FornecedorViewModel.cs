using GenialNet.Controllers.ViewModels.Produto;

namespace GenialNet.Controllers.ViewModels.Fornecedor;

public class FornecedorViewModel
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public EnderecoViewModel Endereco { get; set; }
    public string Telefone { get; set; }
    public ICollection<ProdutoViewModel> Produtos { get; set; } = new List<ProdutoViewModel>();
}

public class EnderecoViewModel
{
    public long Id { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Unidade { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
    public string Uf { get; set; }
    public string Ibge { get; set; }
    public string Gia { get; set; }
    public string Ddd { get; set; }
    public string Siafi { get; set; }
}