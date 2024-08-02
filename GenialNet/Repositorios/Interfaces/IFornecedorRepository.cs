using GenialNet.Entidades;

namespace GenialNet.Repositorios.Interfaces;

public interface IFornecedorRepository : IRepositoryBase<Fornecedor>
{
    Task<bool> VerificarProdutoDuplicado(Fornecedor fornecedor);
}