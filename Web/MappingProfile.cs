using AutoMapper;
using Domain.Models;
using Web.Models;

namespace Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TimeSheetEntry, NewEntry>()
                .ForMember(dest => dest.Time, opt => opt.MapFrom(src => src.WorkTime))
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company.Name));
            CreateMap<NewEntry, TimeSheetEntry>()
                .ForMember(dest => dest.WorkTime, opt => opt.MapFrom(src => src.Time))
                .ForMember(dest => dest.Company.Name, opt => opt.MapFrom(src => src.Company));
        }
    }
}