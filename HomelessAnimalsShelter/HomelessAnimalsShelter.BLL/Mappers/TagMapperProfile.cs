using AutoMapper;
using HomelessAnimalsShelter.Core.Dtos;
using HomelessAnimalsShelter.Core.Models;

namespace HomelessAnimalsShelter.BLL.Mappers
{
    public class TagMapperProfile : Profile
    {
        public TagMapperProfile()
        {
            CreateMap<TagDto, TagOutputModel>();
        }
    }
}
