using GenialNet.Entidades;
using GenialNet.Excessao;
using GenialNet.Repositorios;
using GenialNet.Repositorios.Interfaces;
using GenialNet.Servicos.Interfaces;

namespace GenialNet.Servicos;

public class ProdutoService : BaseService<Produto>, IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public override async Task<IEnumerable<Produto>> ObterTodos()
    {
        return await _produtoRepository.ObterTodos();
    }

    public override async Task<Produto> ObterPorId(long id)
    {
        return await _produtoRepository.ObterPorId(id);
    }

    public override async Task<Produto> Adicionar(Produto produto)
    {
        await ValidarProdutoDuplicado(produto);

        await _produtoRepository.Adicionar(produto);

        return produto;
    }

    public override async Task<Produto> Atualizar(Produto produto)
    {
        await _produtoRepository.Atualizar(produto);

        return produto;
    }

    public override async Task Excluir(long id)
    {
        await _produtoRepository.Excluir(id);
    }

    public async Task<bool> Existe(long id)
    {
        var produto = await _produtoRepository.ObterPorId(id);
        return produto is not null;
    }

    private async Task ValidarProdutoDuplicado(Produto produto)
    {
        if (await _produtoRepository.VerificarProdutoDuplicado(produto))
            throw new ExcessaoNegocio("Não é possível cadastrar produtos duplicadosd para o mesmo Fornecedor, Marca, Descrição e Valor.");
    }
}