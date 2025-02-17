using AutoMapper;
using HomelessAnimalsShelter.Core.Dtos;
using HomelessAnimalsShelter.Core.Models;

namespace HomelessAnimalsShelter.BLL.Mappers
{
	public class ReviewMapperProfile : Profile
	{
		public ReviewMapperProfile()
		{
			CreateMap<ReviewDto, ReviewOutputModel>();
		}
	}
}
