using GenialNet.Controllers.ViewModels.Endereco;
using GenialNet.Controllers.ViewModels.Produto;
using System.ComponentModel.DataAnnotations;

namespace GenialNet.Controllers.ViewModels.Fornecedor;

public class AdicionarFornecedorViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O CNPJ é obrigatório.")]
    public string CNPJ { get; set; }
    [Required(ErrorMessage = "O CEP é obrigatório.")]
    public string Cep { get; set; }
    [Required(ErrorMessage = "O telefone é obrigatório.")]
    public string Telefone { get; set; }
    [Required(ErrorMessage = "Os produtos são obrigatórios.")]
    public IEnumerable<AdicionarProdutoViewModel> Produtos { get; set; } = new List<AdicionarProdutoViewModel>();
}