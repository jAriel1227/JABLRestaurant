using RestauranteAPI.Core.Application.Enums;
using RestauranteAPI.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<Users> userManager,RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.SUPERADMIN.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.ADMINISTRATOR.ToString()));            
            await roleManager.CreateAsync(new IdentityRole(Roles.WAITER.ToString()));
        }
    }
}
