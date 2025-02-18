using AutoMapper;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.DAL;

namespace HomelessAnimalsShelter.BLL
{
	public class ShelterManager
	{
		private ShelterRepository _repository;
		private Mapper _mapper;

		public ShelterManager()
		{
			MapperConfiguration configuration = new MapperConfiguration(
				cfg => {
					cfg.AddProfile(new ShelterMapperProfile());
				});

			_mapper = new Mapper(configuration);

			_repository = new ShelterRepository();
		}

		public ShelterOutputModel GetShelterById(int id)
		{
			return _mapper.Map<ShelterOutputModel>(_repository.GetShelterById(id));
		}
	}
}
