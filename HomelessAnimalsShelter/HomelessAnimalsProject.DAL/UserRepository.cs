using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class UserRepository
	{
		public UserDto GetUserById(int id)
		{
			using (Context context = new Context())
			{
				return context.Users.Where(u => u.Id == id).First();
			}
		}
	} 
}
