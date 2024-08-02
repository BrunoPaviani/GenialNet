using GenialNet.Entidades;
using GenialNet.Entidades.Contexto;
using GenialNet.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenialNet.Repositorios;

public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
{
    private readonly GenialNetContext _context;

    public ProdutoRepository(GenialNetContext context) : base(context)
    {
        _context = context;
    }

    public Task<bool> VerificarProdutoDuplicado(Produto produto)
    {
        return _context.Produtos.AnyAsync(c => 
            c.Marca.ToLower().Equals(produto.Marca.ToLower()) &&
            c.Descricao.ToLower().Equals(produto.Descricao.ToLower()) &&
            c.FornecedorId == produto.FornecedorId &&
            c.Valor == produto.Valor);
    }
}