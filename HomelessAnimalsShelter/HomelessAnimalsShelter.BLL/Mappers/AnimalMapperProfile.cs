using AutoMapper;
using HomelessAnimalsShelter.Core.Dtos;
using HomelessAnimalsShelter.Core.Models;

namespace HomelessAnimalsShelter.BLL.Mappers
{
	public class AnimalMapperProfile:Profile
	{
		public AnimalMapperProfile()
		{
			CreateMap<AnimalDto, AnimalPageOutputModel>();
			CreateMap<AnimalDto, AnimalCardOutputModel>();
		}
	}
}
