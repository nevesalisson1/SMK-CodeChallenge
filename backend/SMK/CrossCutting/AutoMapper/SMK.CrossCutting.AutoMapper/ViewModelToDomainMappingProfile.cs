using AutoMapper;
using SMK.Application.ViewModels;
using SMK.Domain.Models;

namespace SMK.CrossCutting.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<DataViewModel, Data>();
            CreateMap<RegistrarCargueiroViewModel, RetornoCargueiro>()
                .ForMember(
                    dest => dest.RetornoDateTime,
                    opt => opt.MapFrom(src => $"{src.RegistroDateTime}")
                );
            CreateMap<RegistrarCargueiroViewModel, SaidaCargueiro>()
                .ForMember(
                    dest => dest.SaidaDateTime,
                    opt => opt.MapFrom(src => $"{src.RegistroDateTime}")
                );
        }
    }
}