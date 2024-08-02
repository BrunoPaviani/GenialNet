using GenialNet.Entidades;
using GenialNet.Entidades.Contexto;
using GenialNet.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenialNet.Repositorios;

public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
{
    private new readonly GenialNetContext _context;

    public FornecedorRepository(GenialNetContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Fornecedor>> ObterTodos()
    {
        return await _context.Fornecedores
            .Include(f => f.Endereco)
            .Include(f => f.Produtos)
            .ToListAsync();
    }

    public override async Task<Fornecedor> ObterPorId(long id)
    {
        return await _context.Fornecedores.Include(c => c.Produtos).Include(c => c.Endereco).FirstOrDefaultAsync(c => c.Id == id);
    }

    public Task<bool> VerificarProdutoDuplicado(Fornecedor fornecedor)
    {
        return _context.Fornecedores.AnyAsync(c =>
            c.Nome.ToLower().Equals(fornecedor.Nome.ToLower()));
    }
}