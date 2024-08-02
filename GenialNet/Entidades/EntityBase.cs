namespace GenialNet.Entidades;

public class EntityBase : IEntityBase
{
    public long Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAlteracao { get; set; }
}