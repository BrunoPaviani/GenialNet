using AutoMapper;
using GenialNet.Controllers.ViewModels.Fornecedor;
using GenialNet.Entidades;
using GenialNet.Extensions;
using GenialNet.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenialNet.Controllers;

[ApiController]
[Route("[controller]")]
public class FornecedorController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IFornecedorService _fornecedorService;

    public FornecedorController(
        IMapper mapper,
        IFornecedorService fornecedorService)
    {
        _mapper = mapper;
        _fornecedorService = fornecedorService;
    }

    [HttpPost("novo")]
    public async Task<IActionResult> Novo([FromBody] AdicionarFornecedorViewModel adicionarFornecedorViewModel)
    {
        var fornecedor = _mapper.Map<Fornecedor>(adicionarFornecedorViewModel);

        if (fornecedor is null)
            return BadRequest("Não foi possível realizar o mapeamento para entidade.");

        fornecedor.CNPJ = fornecedor.CNPJ.RemoverCaracteresEspeciais();

        fornecedor = await _fornecedorService.Adicionar(fornecedor, adicionarFornecedorViewModel.Cep);

        return CreatedAtAction(nameof(Obter), new { id = fornecedor.Id }, adicionarFornecedorViewModel);
    }

    [HttpGet("obter/{id}")]
    public async Task<IActionResult> Obter([FromRoute] long id)
    {
        var existeFornecedor = await _fornecedorService.Existe(id);

        if (!existeFornecedor)
            return NotFound();

        return Ok(_mapper.Map<FornecedorViewModel>(await _fornecedorService.ObterPorId(id)));
    }

    [HttpGet("obter-todos")]
    public async Task<IActionResult> ObterTodos()
    {
        var fornecedores = await _fornecedorService.ObterTodos();
        return Ok(_mapper.Map<IEnumerable<FornecedorViewModel>>(fornecedores));
    }

    [HttpPut("editar")]
    public async Task<IActionResult> Editar([FromBody] EditarFornecedorViewModel editarFornecedorViewModel)
    {
        var existeFornecedor = await _fornecedorService.Existe(editarFornecedorViewModel.Id);

        if (!existeFornecedor)
            return NotFound();

        var fornecedor = await _fornecedorService.ObterPorId(editarFornecedorViewModel.Id);

        DeViewModelParaEntidade(editarFornecedorViewModel, fornecedor);

        fornecedor = await _fornecedorService.Atualizar(fornecedor);

        return Ok(_mapper.Map<FornecedorViewModel>(fornecedor));
    }

    [HttpDelete("excluir/{id}")]
    public async Task<IActionResult> Excluir([FromRoute] long id)
    {
        var existeFornecedor = await _fornecedorService.Existe(id);

        if (!existeFornecedor)
            return NotFound();

        await _fornecedorService.Excluir(id);

        return Ok();
    }

    private void DeViewModelParaEntidade(EditarFornecedorViewModel editarFornecedorViewModel, Fornecedor fornecedor)
    {
        fornecedor.Nome = editarFornecedorViewModel.Nome;
        fornecedor.CNPJ = editarFornecedorViewModel.CNPJ;
        fornecedor.Telefone = editarFornecedorViewModel.Telefone;

        fornecedor.Endereco = _mapper.Map<Endereco>(editarFornecedorViewModel.Endereco);

        foreach (var produtoViewModel in editarFornecedorViewModel.Produtos)
        {
            fornecedor.Produtos.Add(_mapper.Map<Produto>(produtoViewModel));
        }

        foreach (var produtoId in editarFornecedorViewModel.ProdutosSeremExcluidos)
        {
            var produto = fornecedor.Produtos.FirstOrDefault(p => p.Id == produtoId);
            if (produto != null)
            {
                fornecedor.Produtos.Remove(produto);
            }
        }
    }
}