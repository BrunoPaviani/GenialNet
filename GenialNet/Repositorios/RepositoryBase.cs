using GenialNet.Entidades.Contexto;
using GenialNet.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenialNet.Repositorios;

public class RepositoryBase<T> : IRepositoryBase<T> where T: class
{
    protected readonly GenialNetContext _context;
    protected readonly DbSet<T> _dbSet;
    public RepositoryBase(
        GenialNetContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> ObterTodos()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task<T> ObterPorId(long id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task Adicionar(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task Atualizar(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task Excluir(long id)
    {
        var entity = await ObterPorId(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}