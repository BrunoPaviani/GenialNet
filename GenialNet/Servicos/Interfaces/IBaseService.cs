namespace GenialNet.Servicos.Interfaces;

public interface IBaseService<T> where T : class
{
    Task<IEnumerable<T>> ObterTodos();
    Task<T> ObterPorId(long id);
    Task<T> Adicionar(T fornecedor);
    Task<T> Atualizar(T obj);
    Task Excluir(long obj);
}