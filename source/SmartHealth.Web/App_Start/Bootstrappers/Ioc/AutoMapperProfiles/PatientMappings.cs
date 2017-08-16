using AutoMapper;
using SmartHealth.Core.Domain;
using SmartHealth.Web.ViewModels;

namespace SmartHealth.Web.App_Start.Bootstrappers.Ioc.AutoMapperProfiles
{
    public class PatientMappings : Profile
    {
        protected override void Configure()
        {
            CreateMap<Patient, PatientViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PatientId));
            CreateMap<PatientViewModel, Patient>()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.Id));
        }
    }
}