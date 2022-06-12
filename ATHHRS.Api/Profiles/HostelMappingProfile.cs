using ATHHRS.API.Entities;
using ATHHRS.API.Models;
using AutoMapper;

namespace ATHHRS.API.Profiles
{
    public class HostelMappingProfile : Profile
    {
        public HostelMappingProfile()
        {
            CreateMap<Hostel, HostelDto>()
                .ForMember(m => m.City, c => c.MapFrom(s => s.Address.City))
                .ForMember(m => m.Street, c => c.MapFrom(s => s.Address.Street))
               .ForMember(m => m.PostalCode, c => c.MapFrom(s => s.Address.PostalCode));

            CreateMap<Room, RoomDto>();

            CreateMap<CreateHostelDto, Hostel>()
                .ForMember(r => r.Address,
                    c => c.MapFrom(dto => new Address()
                        {City = dto.City, Street = dto.Street, PostalCode = dto.PostalCode}));

        }
    }
}
