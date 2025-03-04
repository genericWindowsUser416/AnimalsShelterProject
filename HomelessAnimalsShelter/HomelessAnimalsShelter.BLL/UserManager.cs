using AutoMapper;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.DAL;
using HomelessAnimalsShelter.Core;

namespace HomelessAnimalsShelter.BLL
{
    public class UserManager
    {
        private UserRepository _repository;
        private Mapper _mapper;

        public UserManager()
        {
            MapperConfiguration configuration = new MapperConfiguration(
                cfg => {
                    cfg.AddProfile(new UserMapperProfile());
                });

            _mapper = new Mapper(configuration);

            _repository = new UserRepository();
        }

        public List<UserOutputModel> GetAllUsers()
        {
            //return _mapper.Map<List<UserOutputModel>>(_repository.GetAllUsers());
            return null;
        }

        public UserOutputModel GetUserById(int id)
        {
            return _mapper.Map<UserOutputModel>(_repository.GetUserById(id));
        }

        public UserType GetUserTypeByLogin(string login)
        {
            return _mapper.Map<UserType>(_repository.GetUserTypeByLogin(login));
        }
        
    }
}
