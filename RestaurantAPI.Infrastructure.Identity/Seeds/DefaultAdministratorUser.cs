using RestaurantAPI.Core.Application.Enums;
using RestaurantAPI.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Infrastructure.Identity.Seeds
{
    public class DefaultAdministratorUser
    {
        public static async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {
            Users adminUser = new() {
                UserName = "DefaultSuperAdmin",
                Name = "Johanly",
                LastName = "Baez",
                Email = "baezjohanly@gmail.com",
                EmailConfirmed = true,
                PhoneNumber="+1 829 804 0292",
                PhoneNumberConfirmed = true
            };

            Users adminUser1 = new()
            {
                UserName = "DefaultAdmin",
                Name = "Ariel",
                LastName = "Baez",
                Email = "baezjohanly16@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "+1 829 804 0292",
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u=>u.Id!=adminUser.Id))
            {
                var user = await userManager.FindByEmailAsync(adminUser.Email);

                if (user==null)
                {
                    await userManager.CreateAsync(adminUser,"122702");

                    await userManager.AddToRoleAsync(adminUser,Roles.SUPERADMIN.ToString());
                }
            }

            if (userManager.Users.All(u => u.Id != adminUser1.Id))
            {
                var user = await userManager.FindByEmailAsync(adminUser1.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(adminUser, "122702");

                    await userManager.AddToRoleAsync(adminUser, Roles.ADMINISTRATOR.ToString());
                }
            }

        }
    }
}
