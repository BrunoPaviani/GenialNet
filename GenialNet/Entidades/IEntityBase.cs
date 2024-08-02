namespace GenialNet.Entidades;

public interface IEntityBase
{
    long Id { get; set; }
    DateTime DataCriacao { get; set; }
    DateTime DataAlteracao { get; set; }
}