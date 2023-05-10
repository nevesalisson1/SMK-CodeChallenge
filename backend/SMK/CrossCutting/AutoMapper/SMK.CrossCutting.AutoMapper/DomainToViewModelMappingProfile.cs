using AutoMapper;
using SMK.Application.ViewModels;
using SMK.Domain.Models;

namespace SMK.CrossCutting.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Minerios, MineriosViewModel>();
            CreateMap<RetornoCargueiro, RegistrarCargueiroViewModel>();
            CreateMap<SaidaCargueiro, RegistrarCargueiroViewModel>();
        }
    }
}
