namespace GenialNet.Controllers.ViewModels.Fornecedor;

public class EditarFornecedorViewModel : AdicionarFornecedorViewModel
{
    public long Id { get; set; }
    public EditarEnderecoViewModel Endereco { get; set; }
    public IEnumerable<long> ProdutosSeremExcluidos { get; set; } = new List<long>();
}