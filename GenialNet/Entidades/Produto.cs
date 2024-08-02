using GenialNet.Entidades.Enumeradores;

namespace GenialNet.Entidades;

public class Produto : EntityBase
{
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public UnidadeMedida UnidadeMedida { get; set; }
    public decimal Valor { get; set; }
    public virtual long FornecedorId { get; set; }
}