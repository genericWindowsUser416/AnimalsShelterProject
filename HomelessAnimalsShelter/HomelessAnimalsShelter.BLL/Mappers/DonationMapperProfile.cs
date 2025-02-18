using AutoMapper;
using HomelessAnimalsShelter.Core.Dtos;
using HomelessAnimalsShelter.Core.Models;

namespace HomelessAnimalsShelter.BLL.Mappers
{
	public class DonationMapperProfile : Profile
	{
		public DonationMapperProfile()
		{
			CreateMap<DonationDto, DonationOutputModel>();
		}
	}
}
