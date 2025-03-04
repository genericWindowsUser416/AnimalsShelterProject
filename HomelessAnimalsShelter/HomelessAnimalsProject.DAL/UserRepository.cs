using HomelessAnimalsShelter.Core;
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

		public List<UserDto> GetAllUsers()
		{
			using (Context context = new Context())
			{
				return context.Users
							  .Select(u => new UserDto
							  {
								  Id = u.Id,
								  Login = u.Login,
								  Password = u.Password,
								  UserType = u.UserType
							  })
							  .ToList();
			}
		}

        public UserType GetUserTypeByLogin(string login)
        {
            {
                using (Context context = new Context())
                {
                    //return context.Users.Where(u => u.Login == login).FirstOrDefault();

                    var user = context.Users.Where(u => u.Login == login).FirstOrDefault();
                    if (user != null)
                    {
                        return (UserType)user.UserType;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(user), "User is null!");
                    }
                }
            }
        }
    }
}
