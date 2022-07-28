using RestauranteAPI.Core.Application.Enums;
using RestauranteAPI.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.Identity.Seeds
{
    public class DefaultAdministratorUser
    {
        public static async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {    
            Users adminUser = new()
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
                    await userManager.CreateAsync(adminUser, "27P@ssword");

                    await userManager.AddToRoleAsync(adminUser,Roles.ADMINISTRATOR.ToString());
                    await userManager.AddToRoleAsync(adminUser, Roles.WAITER.ToString());
                }
            } 
        }
    }
}
