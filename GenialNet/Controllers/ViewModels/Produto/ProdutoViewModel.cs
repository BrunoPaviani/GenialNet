using GenialNet.Controllers.ViewModels.Fornecedor;
using GenialNet.Entidades.Enumeradores;

namespace GenialNet.Controllers.ViewModels.Produto;

public class ProdutoViewModel
{
    public long Id { get; set; }
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public UnidadeMedida UnidadeMedida { get; set; }
    public decimal Valor { get; set; }

    public FornecedorViewModel Fornecedor { get; set; }
}