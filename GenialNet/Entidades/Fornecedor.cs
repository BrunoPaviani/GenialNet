
namespace GenialNet.Entidades;

public class Fornecedor : EntityBase
{
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public Endereco Endereco { get; set; }
    public string Telefone { get; set; }
    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}