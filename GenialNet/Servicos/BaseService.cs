using GenialNet.Servicos.Interfaces;

namespace GenialNet.Servicos;

public abstract class BaseService<T> : IBaseService<T> where T: class
{
    public abstract Task<IEnumerable<T>> ObterTodos();
    public abstract Task<T> ObterPorId(long id);
    public abstract Task<T> Adicionar(T obj);
    public abstract Task<T> Atualizar(T obj);
    public abstract Task Excluir(long id);
}