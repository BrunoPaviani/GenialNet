namespace GenialNet.Repositorios.Interfaces;

public interface IRepositoryBase<T> where T : class
{
    Task<IEnumerable<T>> ObterTodos();
    Task<T> ObterPorId(long id);
    Task Adicionar(T entity);
    Task Atualizar(T entity);
    Task Excluir(long id);
}