using GenialNet.Controllers.ViewModels.Endereco;
using GenialNet.Controllers.ViewModels.Produto;

namespace GenialNet.Controllers.ViewModels.Fornecedor;

public class AdicionarFornecedorViewModel
{
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    
    public string Cep { get; set; }
    public string Telefone { get; set; }
    public IEnumerable<AdicionarProdutoViewModel> Produtos { get; set; } = new List<AdicionarProdutoViewModel>();
}