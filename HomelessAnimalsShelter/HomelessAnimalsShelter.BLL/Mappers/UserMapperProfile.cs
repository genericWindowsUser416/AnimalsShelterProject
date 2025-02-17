using AutoMapper;
using HomelessAnimalsShelter.Core.Dtos;
using HomelessAnimalsShelter.Core.Models;

namespace HomelessAnimalsShelter.BLL.Mappers
{
	public class UserMapperProfile : Profile
	{
		public UserMapperProfile()
		{
			CreateMap<UserDto, UserOutputModel>();
		}
	}
}
