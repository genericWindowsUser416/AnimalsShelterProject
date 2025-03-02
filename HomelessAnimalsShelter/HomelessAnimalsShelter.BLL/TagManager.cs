using AutoMapper;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.DAL;

namespace HomelessAnimalsShelter.BLL
{
    public class TagManager
    {
        private TagRepository _repository;
        private Mapper _mapper;

        public TagManager()
        {
            MapperConfiguration configuration = new MapperConfiguration(
                cfg => {
                    cfg.AddProfile(new TagMapperProfile());
                });

            _mapper = new Mapper(configuration);

            _repository = new TagRepository();
        }

        public List<TagOutputModel> GetAllTags()
        {
            return _mapper.Map<List<TagOutputModel>>(_repository.GetAllTags());
            //return null;
        }

        public TagOutputModel GetTagById(int id)
        {
            return _mapper.Map<TagOutputModel>(_repository.GetTagById(id));
        }
    }
}
