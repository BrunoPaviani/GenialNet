using System.ComponentModel.DataAnnotations;

namespace GenialNet.Controllers.ViewModels.Produto;

public class EditarProdutoViewModel : AdicionarProdutoViewModel
{
    [Required(ErrorMessage = "O id é obrigatório.")]
    public long Id { get; set; }
}