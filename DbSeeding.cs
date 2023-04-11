using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace WebApplicationUser.Data
{
    public static class DbSeeding
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            var userManager = service.GetService<UserManager<Contacts>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();

            await roleManager.CreateAsync(new IdentityRole(Roles.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Roles.User.ToString()));

            //create admin
            var user = new Contacts
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "Eniayo Ibirogba",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Roles.Admin.ToString());
            }

        }
    }
}
