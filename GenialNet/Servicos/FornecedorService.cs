using AutoMapper;
using GenialNet.Controllers.ViewModels.Endereco;
using GenialNet.Entidades;
using GenialNet.Excessao;
using GenialNet.Extensions;
using GenialNet.Repositorios.Interfaces;
using GenialNet.Servicos.Interfaces;
using Newtonsoft.Json;

namespace GenialNet.Servicos;

public class FornecedorService : BaseService<Fornecedor>, IFornecedorService
{
    private readonly IFornecedorRepository _fornecedorRepository;
    private readonly IMapper _mapper;

    public FornecedorService(IFornecedorRepository fornecedorRepository, IMapper mapper)
    {
        _fornecedorRepository = fornecedorRepository;
        _mapper = mapper;
    }

    public override async Task<IEnumerable<Fornecedor>> ObterTodos()
    {
        return await _fornecedorRepository.ObterTodos();
    }

    public override async Task<Fornecedor> ObterPorId(long id)
    {
        return await _fornecedorRepository.ObterPorId(id);
    }

    public override Task<Fornecedor> Adicionar(Fornecedor fornecedor)
    {
        throw new NotImplementedException();
    }

    public override async Task<Fornecedor> Atualizar(Fornecedor fornecedor)
    {
        await _fornecedorRepository.Atualizar(fornecedor);

        return fornecedor;
    }

    public override async Task Excluir(long id)
    {
        await _fornecedorRepository.Excluir(id);
    }

    public async Task<bool> Existe(long id)
    {
        var fornecedor = await _fornecedorRepository.ObterPorId(id);
        return fornecedor is not null;
    }

    public async Task<Fornecedor> Adicionar(Fornecedor fornecedor, string cep)
    {
        await ValidarProdutoDuplicado(fornecedor);

        var adicionarEnderecoViewModel = await ObterEndereco(cep);
        fornecedor.Endereco = _mapper.Map<Endereco>(adicionarEnderecoViewModel);

        fornecedor.Endereco.Cep = fornecedor.Endereco.Cep.RemoverCaracteresEspeciais();

        await _fornecedorRepository.Adicionar(fornecedor);

        return fornecedor;
    }

    private async Task ValidarProdutoDuplicado(Fornecedor produto)
    {
        if (await _fornecedorRepository.VerificarProdutoDuplicado(produto))
            throw new ExcessaoNegocio("Não é possível cadastrar Fornecedor com um nome já existente.");
    }

    private async Task<AdicionarEnderecoViewModel> ObterEndereco(string cep)
    {
        using var httpclient = new HttpClient();
        var response = await httpclient.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
        var adicionarEnderecoViewModel = JsonConvert.DeserializeObject<AdicionarEnderecoViewModel>(response);
        return adicionarEnderecoViewModel;
    }
}