using RestauranteAPI.Core.Application.Enums;
using RestauranteAPI.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.Identity.Seeds
{
    public class DefaultWaiterUser
    {
        public static async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {               
            Users waiter = new()
            {
                UserName = "DefaultWaiter",
                Name = "Juanly",
                LastName = "Rodriguez",
                Email = "juanly@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "+1 849 322 0382",
                PhoneNumberConfirmed = true
            };                       

            if (userManager.Users.All(u => u.Id != waiter.Id))
            {
                var user = await userManager.FindByEmailAsync(waiter.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(waiter, "27P@ssword");

                    await userManager.AddToRoleAsync(waiter, Roles.WAITER.ToString());
                }
            }

        }
    }
}
