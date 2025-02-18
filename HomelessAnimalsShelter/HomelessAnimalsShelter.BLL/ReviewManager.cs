using AutoMapper;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.DAL;

namespace HomelessAnimalsShelter.BLL
{
	internal class ReviewManager
	{
		private ReviewRepository _repository;
		private Mapper _mapper;

		public ReviewManager()
		{
			MapperConfiguration configuration = new MapperConfiguration(
				cfg => {
					cfg.AddProfile(new ReviewMapperProfile());
				});

			_mapper = new Mapper(configuration);

			_repository = new ReviewRepository();
		}

		public List<AnimalCardOutputModel> GetAllReviews()
		{
			return _mapper.Map<List<AnimalCardOutputModel>>(_repository.GetAllReviews());
		}

		public AnimalPageOutputModel GetReviewsById(int id)
		{
			return _mapper.Map<AnimalPageOutputModel>(_repository.GetReviewById(id));
		}
	}
}
