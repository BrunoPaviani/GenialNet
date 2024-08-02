using AutoMapper;
using GenialNet.Controllers.ViewModels.Produto;
using GenialNet.Entidades;

namespace GenialNet.AutoMapper;

public class ProdutoMapper : Profile
{
    public ProdutoMapper()
    {
        CreateMap<Produto, AdicionarProdutoViewModel>().ReverseMap();
        CreateMap<Produto, EditarProdutoViewModel>().ReverseMap();
        CreateMap<Produto, ProdutoViewModel>().ReverseMap();
    }
}