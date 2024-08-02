using AutoMapper;
using GenialNet.Controllers.ViewModels.Endereco;
using GenialNet.Controllers.ViewModels.Fornecedor;
using GenialNet.Entidades;

namespace GenialNet.AutoMapper;

public class FornecedorMapper : Profile
{
    public FornecedorMapper()
    {
        CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
        CreateMap<Fornecedor, AdicionarFornecedorViewModel>().ReverseMap();
    }
}