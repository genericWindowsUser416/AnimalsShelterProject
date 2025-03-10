﻿using AutoMapper;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.DAL;

namespace HomelessAnimalsShelter.BLL
{
	public class DonationManager
	{
		private DonationRepository _repository;
		private Mapper _mapper;

		public DonationManager()
		{
			MapperConfiguration configuration = new MapperConfiguration(
				cfg => {
					cfg.AddProfile(new DonationMapperProfile());
				});

			_mapper = new Mapper(configuration);

			_repository = new DonationRepository();
		}

		public List<DonationOutputModel> GetAllDonations()
		{
			return _mapper.Map<List<DonationOutputModel>>(_repository.GetAllDonations());
		}

		public DonationOutputModel GetDonationById(int id)
		{
			return _mapper.Map<DonationOutputModel>(_repository.GetDonationById(id));
		}

        public List<DonationOutputModel> GetDonationsByShelterId(int id)
        {
            return _mapper.Map<List<DonationOutputModel>>(_repository.GetDonationsByShelterId(id));
        }
    }
}
