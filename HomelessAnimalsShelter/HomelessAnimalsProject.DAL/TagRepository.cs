using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
    public class TagRepository
    {
        public TagDto GetTagById(int id)
        {
            using (Context context = new Context())
            {
                return context.Tags.Where(t => t.Id == id).First();
            }
        }

        public List<TagDto> GetAllTags()
        {
            using (Context context = new Context())
            {
                return context.Tags
                              .Select(t => new TagDto
                              {
                                  Id = t.Id,
                                  Name = t.Name
                              })
                              .ToList();
            }
        }
    }
}
