using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GenialNet.Entidades.Enumeradores;

namespace GenialNet.Controllers.ViewModels.Produto;

public class AdicionarProdutoViewModel
{
    [Required(ErrorMessage = "A descrição é obrigatória")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "A marca é obrigatória")]
    public string Marca { get; set; }

    [Required(ErrorMessage = "A unidade de medida é obrigatória")]
    public UnidadeMedida UnidadeMedida { get; set; }
    [Required(ErrorMessage = "A unidade de medida é obrigatória")]
    public decimal Valor { get; set; }
    [Required(ErrorMessage = "O Fornecedor é obrigatório")]
    public long FornecedorId { get; set; }
}