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
            Console.WriteLine("Started..");

            //foreach (var i in context.Users.ToList())
            //{
            //    Console.WriteLine($"{i.Id} {i.Login}");
            //}

            //var users = new List<UserDto>
            //{
            //    new UserDto { Id = 1, Login = "user1", Password = "password1", UserType = Core.UserType.Seller },
            //    new UserDto { Id = 2, Login = "user2", Password = "password2", UserType = Core.UserType.Seller },
            //    new UserDto { Id = 3, Login = "123456789", Password = "qwertyuiop", UserType = Core.UserType.Admin }
            //};
            //context.Users.AddRange(users);
            //context.SaveChanges();

            //var shelters = new List<ShelterDto>
            //{
            //    new ShelterDto { Id = 1, Name = "����� �����", Description = "������� �����", City = "����", User = users[0] },
            //    new ShelterDto { Id = 2, Name = "����� �����", Description = "������ �����", City = "������", User = users[1] }
            //};
            //context.Shelters.AddRange(shelters);
            //context.SaveChanges();

            //var donations = new List<DonationDto>
            //{
            //    new DonationDto { Id = 1, Name = "�� ����", Description = "����� �����", Shelter = shelters[0], NeededMoney = 5000, CollectedMoney = 0 },
            //    new DonationDto { Id = 2, Name = "�� ������ ����", Description = "�������� �����", Shelter = shelters[1], NeededMoney = 1000, CollectedMoney = 0 }
            //};
            //context.Donations.AddRange(donations);
            //context.SaveChanges();

            //var tags = new List<TagDto>
            //{
            //    new TagDto { Id = 1, Name = "������" },
            //    new TagDto { Id = 2, Name = "�����" },
            //    new TagDto { Id = 3, Name = "�������" },
            //    new TagDto { Id = 4, Name = "����" },
            //    new TagDto { Id = 5, Name = "���������" }
            //};
            //context.Tags.AddRange(tags);
            //context.SaveChanges();

            //var animals = new List<AnimalDto>
            //{
            //    new AnimalDto { Id = 1, Name = "Oleg", Description = "�������� �����", TagDtos = new List<TagDto> { tags[1], tags[2] }, Shelter = shelters[0] },
            //    new AnimalDto { Id = 2, Name = "Gleb", Description = "�������� ����� �����", TagDtos = new List<TagDto> { tags[3], tags[2] }, Shelter = shelters[1] }
            //};
            //context.Animals.AddRange(animals);
            //context.SaveChanges();



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
