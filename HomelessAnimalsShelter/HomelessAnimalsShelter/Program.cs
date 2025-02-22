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



            //int userId = 3;
            //UserDto user = userRepository.GetUserById(userId);
            //if (user != null)
            //{
            //	Console.WriteLine($"User ID: {user.Id}, Login: {user.Login}, UserType: {user.UserType}");
            //}
            //else
            //{
            //	Console.WriteLine("User not found.");
            //}
            UserRepository userRepository = new UserRepository();
            List<UserDto> users3000 = userRepository.GetAllUsers();
			Console.WriteLine("looking for users");
			foreach (UserDto user in users3000)
			{
				Console.WriteLine($"User ID: {user.Id}, Login: {user.Login}, UserType: {user.UserType}");
			}

            //         UserDto user3 = new UserDto()
            //         {
            //             Id = 3,
            //	Login = "123456789",
            //	Password = "qwertyuiop",
            //             UserType = Core.UserType.Seller
            //};

            //         context.Users.Add(user3);

            //ShelterDto shelterAAA = new ShelterDto()
            //{
            //    Id = 1,
            //    Name = "Приют Омска",
            //    Description = "Хороший приют",
            //    City = "Омск",
            //    User = context.Users.Where(u => u.Id == 3).First()
            //};

            //context.Shelters.Add(shelterAAA);

            //ShelterDto shelterBBB = new ShelterDto()
            //{
            //    Id = 2,
            //    Name = "Приют Глеба",
            //    Description = "Лучший приют",
            //    City = "Москва",
            //    User = context.Users.Where(u => u.Id == 2).First()
            //};
            //context.Shelters.Add(shelterBBB);


            //DonationDto donationAAA = new DonationDto()
            //{
            //    Id = 1,
            //    Name = "На корм",
            //    Description = "Дайте денег",
            //    Shelter = context.Shelters.Where(s => s.Id == 1).First(),
            //    NeededMoney = 5000,
            //    CollectedMoney = 0
            //};
            //DonationDto donationBBB = new DonationDto()
            //{
            //    Id = 2,
            //    Name = "На нужные вещи",
            //    Description = "Описание здесь",
            //    Shelter = context.Shelters.Where(s => s.Id == 2).First(),
            //    NeededMoney = 1000,
            //    CollectedMoney = 0
            //};

            //context.Donations.Add(donationAAA);
            //context.Donations.Add(donationBBB);

            //TagDto TagAAA = new TagDto()
            //{
            //    Id = 1,
            //    Name = "Собака"
            //};

            //TagDto TagBBB = new TagDto()
            //{
            //    Id = 2,
            //    Name = "Кошка"
            //};

            //TagDto TagCCC = new TagDto()
            //{
            //    Id = 3,
            //    Name = "Быстрая"
            //};

            //TagDto TagDDD = new TagDto()
            //{
            //    Id = 4,
            //    Name = "Бобёр"
            //};

            //context.Tags.Add(TagAAA);
            //context.Tags.Add(TagBBB);
            //context.Tags.Add(TagCCC);
            //context.Tags.Add(TagDDD);


            AnimalDto AnimalAAA = new AnimalDto()
            {
                Id = 1,
                Name = "Oleg",
                Description = "Описание здесь",
                TagDtos = new List<TagDto>
                {
                    context.Tags.Where(t => t.Id == 2).FirstOrDefault(),
                    context.Tags.Where(t => t.Id == 3).FirstOrDefault()
                }
            };

            AnimalDto AnimalBBB = new AnimalDto()
            {
                Id = 2,
                Name = "Gleb",
                Description = "Описание будет здесь",
                TagDtos = new List<TagDto>
                {
                    context.Tags.Where(t => t.Id == 4).FirstOrDefault(),
                    context.Tags.Where(t => t.Id == 3).FirstOrDefault()
                }
            };

            context.Animals.Add(AnimalAAA);
            context.Animals.Add(AnimalBBB);

            context.SaveChanges();





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
