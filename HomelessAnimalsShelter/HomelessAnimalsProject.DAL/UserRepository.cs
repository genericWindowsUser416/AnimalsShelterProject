using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class UserRepository
	{
		public List<UserDto> GetAllUsers()
		{
			var u1 = new UserDto()
			{
				Id = 1,
				Login = "oleg",
				Password = "qqqq",
				UserRole = 2
			};

			var u2 = new UserDto()
			{
				Id = 2,
				Login = "gleb",
				Password = "wwww",
				UserRole = 3
			};

			var u3 = new UserDto()
			{
				Id = 3,
				Login = "qqqwwww",
				Password = "oleggleb",
				UserRole = 2
			};

			return new List<UserDto> { u1, u2, u3 };
		}

		public UserDto GetUserById(int id)
		{
			return new UserDto()
			{
				Id = id,
				Login = "user3000",
				Password = "wwwqqq",
				UserRole = 2
			};
		}
	}
}
