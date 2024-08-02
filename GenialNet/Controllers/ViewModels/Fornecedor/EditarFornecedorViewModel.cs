using System.ComponentModel.DataAnnotations;

namespace GenialNet.Controllers.ViewModels.Fornecedor;

public class EditarFornecedorViewModel : AdicionarFornecedorViewModel
{
    [Required(ErrorMessage = "O Id é obrigatório")]
    public long Id { get; set; }
    [Required(ErrorMessage = "O Endereço é obrigatório")]
    public EditarEnderecoViewModel Endereco { get; set; }
    public IEnumerable<long> ProdutosSeremExcluidos { get; set; } = new List<long>();
}