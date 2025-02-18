using AutoMapper;
using HomelessAnimalsShelter.Core.Dtos;
using HomelessAnimalsShelter.Core.Models;

namespace HomelessAnimalsShelter.BLL.Mappers
{
	public class ShelterMapperProfile : Profile
	{
		public ShelterMapperProfile()
		{
			CreateMap<ShelterDto, ShelterOutputModel>();
		}
	}
}
