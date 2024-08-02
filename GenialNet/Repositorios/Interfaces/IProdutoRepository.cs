using GenialNet.Entidades;

namespace GenialNet.Repositorios.Interfaces;

public interface IProdutoRepository : IRepositoryBase<Produto>
{
    Task<bool> VerificarProdutoDuplicado(Produto produto);
}