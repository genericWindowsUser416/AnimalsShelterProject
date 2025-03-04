using AutoMapper;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.DAL;
using System.Runtime.CompilerServices;
using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.BLL
{
    public class AnimalManager
    {
		private AnimalRepository _repository;
		private Mapper _mapper;

		public AnimalManager()
		{
			MapperConfiguration configuration = new MapperConfiguration(
				cfg => {
					cfg.AddProfile(new AnimalMapperProfile());
				});

			_mapper = new Mapper(configuration);

			_repository = new AnimalRepository();
		}

		public List<AnimalCardOutputModel> GetAllAnimals()
		{
			return _mapper.Map<List<AnimalCardOutputModel>>(_repository.GetAllAnimals());
		}

		public AnimalPageOutputModel GetAnimalById(int id)
		{
			return _mapper.Map<AnimalPageOutputModel>(_repository.GetAnimalById(id));
		}

        public List<AnimalCardOutputModel> GetAnimalsByShelterId(int id)
        {
            return _mapper.Map<List<AnimalCardOutputModel>>(_repository.GetAnimalsByShelterId(id));
        }

		public AnimalInputModel SendAnimalToBase(AnimalInputModel animalInputModel) 
        {
            var animalDto = _mapper.Map<AnimalDto>(animalInputModel);
            _repository.SendAnimalToBase(animalDto);
            return null;
        }
    }
}
