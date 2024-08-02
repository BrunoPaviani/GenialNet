using GenialNet.Entidades;

namespace GenialNet.Servicos.Interfaces;

public interface IProdutoService : IBaseService<Produto>
{
    Task<bool> Existe(long id);
}