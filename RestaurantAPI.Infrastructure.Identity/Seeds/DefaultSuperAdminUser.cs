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
    public class DefaultSuperAdminUser
    {
        public static async Task SeedAsync(UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {
            Users superAmindUser = new() {
                UserName = "DefaultSuperAdmin",
                Name = "Johanly",
                LastName = "Baez",
                Email = "baezjohanly@gmail.com",
                EmailConfirmed = true,
                PhoneNumber="+1 829 804 0292",
                PhoneNumberConfirmed = true
            };          
            
            if (userManager.Users.All(u=>u.Id!= superAmindUser.Id))
            {
                var user = await userManager.FindByEmailAsync(superAmindUser.Email);

                if (user==null)
                {
                    await userManager.CreateAsync(superAmindUser, "27P@ssword");

                    await userManager.AddToRoleAsync(superAmindUser, Roles.SUPERADMIN.ToString());
                    await userManager.AddToRoleAsync(superAmindUser, Roles.ADMINISTRATOR.ToString());
                    await userManager.AddToRoleAsync(superAmindUser, Roles.WAITER.ToString());
                }
            }                    

        }
    }
}
