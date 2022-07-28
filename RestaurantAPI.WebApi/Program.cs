using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestauranteAPI.Infrastructure.Identity.Entities;
using RestauranteAPI.Infrastructure.Identity.Seeds;
using System;
using System.Threading.Tasks;

namespace RestaurantAPI.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var userManager = services.GetRequiredService<UserManager<Users>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                    await DefaultRoles.SeedAsync(userManager, roleManager);
                    await DefaultSuperAdminUser.SeedAsync(userManager, roleManager);
                    await DefaultAdministratorUser.SeedAsync(userManager, roleManager);                   
                    await DefaultWaiterUser.SeedAsync(userManager, roleManager);

                }
                catch (Exception ex)
                {

                }
            }

            host.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
