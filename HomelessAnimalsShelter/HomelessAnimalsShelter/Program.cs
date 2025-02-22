using HomelessAnimalsShelter.UI.Components;
using HomelessAnimalsShelter.DAL;
using HomelessAnimalsShelter.Core.Dtos;
namespace HomelessAnimalsShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Context context = new Context();
            //context.Database.EnsureCreated();
            Console.WriteLine("qqq www ddd");

			//UserDto userDto = new UserDto();
			//userDto.Users = new List<UserDto>()
			//{
			//    new UserDto() { },
			//    new UserDto() { },
			//    new UserDto() { }
			//};

			//context.Groups.Add(groupDto);
			//context.SaveChanges();

			UserRepository userRepository = new UserRepository();

			int userId = 3;
			UserDto user = userRepository.GetUserById(userId);
			if (user != null)
			{
				Console.WriteLine($"User ID: {user.Id}, Login: {user.Login}, UserType: {user.UserType}");
			}
			else
			{
				Console.WriteLine("User not found.");
			}

			//         UserDto user3 = new UserDto()
			//         {
			//             Id = 3,
			//	Login = "123456789",
			//	Password = "qwertyuiop",
			//             UserType = Core.UserType.Seller
			//};

			//         context.Users.Add(user3);

			//UserDto user4 = new UserDto()
			//{
			//	Id = 4,
			//	Login = "gleb30010",
			//	Password = "qqqwwwdd1234d",
			//	UserType = Core.UserType.Admin
			//};

			//context.Users.Add(user4);

			//context.SaveChanges();






			foreach (var i in context.Users.ToList())
			{
			    Console.WriteLine($"{i.Id} {i.Login}");
			}

			var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddBlazorBootstrap();
            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
