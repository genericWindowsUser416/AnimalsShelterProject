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
            Console.WriteLine("qqq www");

			//UserDto userDto = new UserDto();
			//userDto.Users = new List<StudentDto>()
			//{
			//    new StudentDto() { Age = 11, Name = "www" },
			//    new StudentDto() { Age = 11, Name = "eee"},
			//    new StudentDto() { Age = 11, Name = "rrr"},
			//    new StudentDto() { Age = 11, Name = "ttt" }
			//};

			//context.Groups.Add(groupDto);
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
