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
        }
    }
}