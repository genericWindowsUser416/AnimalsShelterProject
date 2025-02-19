namespace HomelessAnimalsShelter.Core.Dtos
{
	public class UserDto
	{
		public int? Id { get; set; }

		public string Login { get; set; }

		public string? Password { get; set; }

		public UserType UserType { get; set; }
	}
}
