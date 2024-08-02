using GenialNet.Entidades;

namespace GenialNet.Servicos.Interfaces;

public interface IFornecedorService : IBaseService<Fornecedor>
{
    Task<bool> Existe(long id);
    Task<Fornecedor> Adicionar(Fornecedor fornecedor, string cep);
}