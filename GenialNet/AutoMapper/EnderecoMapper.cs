using AutoMapper;
using GenialNet.Controllers.ViewModels.Endereco;
using GenialNet.Controllers.ViewModels.Fornecedor;
using GenialNet.Entidades;

namespace GenialNet.AutoMapper;

public class EnderecoMapper : Profile
{
    public EnderecoMapper()
    {
        CreateMap<Endereco, AdicionarEnderecoViewModel>().ReverseMap();
        CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        CreateMap<Endereco, EditarEnderecoViewModel>().ReverseMap();
    }
}