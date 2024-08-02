using AutoMapper;
using GenialNet.Controllers.ViewModels.Fornecedor;
using Microsoft.AspNetCore.Mvc;
using GenialNet.Entidades;
using GenialNet.Servicos.Interfaces;
using GenialNet.Controllers.ViewModels.Produto;
using GenialNet.Repositorios.Interfaces;

namespace GenialNet.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _produtoService;
    private readonly IFornecedorRepository _fornecedorRepository;
    private readonly IMapper _mapper;

    public ProdutoController(
        IProdutoService produtoService,
        IMapper mapper, 
        IFornecedorRepository fornecedorRepository)
    {
        _produtoService = produtoService;
        this._mapper = mapper;
        _fornecedorRepository = fornecedorRepository;
    }

    [HttpPost("novo")]
    public async Task<IActionResult> Novo([FromBody] AdicionarProdutoViewModel adicionarProdutoViewModel)
    {
        var produto = _mapper.Map<Produto>(adicionarProdutoViewModel);

        if (produto is null)
            return BadRequest("Não foi possível realizar o mapeamento para entidade.");

        produto = await _produtoService.Adicionar(produto);

        return CreatedAtAction(nameof(Obter), new { id = produto.Id }, adicionarProdutoViewModel);
    }

    [HttpGet("obter/{id}")]
    public async Task<IActionResult> Obter([FromRoute] long id)
    {
        var existeProduto = await _produtoService.Existe(id);

        if (!existeProduto)
            return NotFound();

        var produto = await _produtoService.ObterPorId(id);
        var produtoViewModel = _mapper.Map<ProdutoViewModel>(produto);

        produtoViewModel.Fornecedor = _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterPorId(produto.FornecedorId));

        return Ok(produtoViewModel);
    }

    [HttpGet("obter-todos")]
    public async Task<IActionResult> ObterTodos()
    {
        var produtoViewModels = _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoService.ObterTodos());
        return Ok(produtoViewModels);
    }

    [HttpPut("editar")]
    public async Task<IActionResult> Editar([FromBody] EditarProdutoViewModel editarProdutoViewModel)
    {
        var produto = await _produtoService.ObterPorId(editarProdutoViewModel.Id);

        if (produto is null)
            return NotFound();

        produto = _mapper.Map(editarProdutoViewModel, produto);

        produto = await _produtoService.Atualizar(produto);

        return Ok(_mapper.Map<ProdutoViewModel>(produto));
    }

    [HttpDelete("excluir/{ìd}")]
    public async Task<IActionResult> Excluir([FromRoute] long id)
    {
        var existeProduto = await _produtoService.Existe(id);

        if (existeProduto)
            return NotFound();

        await _produtoService.Excluir(id);

        return Ok();
    }
}