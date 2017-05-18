using Bravo.Models;
using Bravo.Models.DatabaseEntities;
using Bravo.Models.DatabaseEntities.Relation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Data
{
    public class ApplicationDbContextSeed
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IServiceProvider _serviceProvider;

        public ApplicationDbContextSeed(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _applicationDbContext = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider.GetService<ApplicationDbContext>(); 
        }

        public void Migrate()
        {
            _applicationDbContext.Database.Migrate();
        }

        public async Task EnsureSeedData()
        {
            var roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = _serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            foreach (var role in Enum.GetNames(typeof(BravoRoles)))
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            await CreateUserIfNotExist(userManager, "admin@test.de", BravoRoles.Administrator.ToString());
            await CreateUserIfNotExist(userManager, "user@test.de", BravoRoles.User.ToString());

            await CreateRoomIfNotExist(1, "Raum 01");
            await CreateToolIfNotExist(1, "Gerät 01");

            await _applicationDbContext.SaveChangesAsync();

            Room room = _applicationDbContext.Rooms.Include(s => s.RoomToolRelations).First(r => r.Id == 1);
            Tool tool = _applicationDbContext.Tools.First(r => r.Id == 1);
            if (room.RoomToolRelations == null || room.RoomToolRelations.Count == 0)
            {
                room.RoomToolRelations = new List<RoomToolRelation>() { new RoomToolRelation() { Room = room, Tool = tool } };
            }

            await _applicationDbContext.SaveChangesAsync();
        }

        private async Task CreateRoomIfNotExist(long id, string roomName)
        {
            Room room = await _applicationDbContext.Rooms.SingleOrDefaultAsync(r => r.Id == id);

            if (room != null)
            {
                return;
            }

            _applicationDbContext.Rooms.Add(new Room() { Name = roomName });
        }

        private async Task CreateToolIfNotExist(long id, string toolName)
        {
            Tool tool = await _applicationDbContext.Tools.SingleOrDefaultAsync(r => r.Id == id);

            if (tool != null)
            {
                return;
            }

            _applicationDbContext.Tools.Add(new Tool() { Name = toolName });
        }

        private async Task CreateUserIfNotExist(UserManager<ApplicationUser> userManager, string email, string role)
        {
            ApplicationUser userFromDatabase = await userManager.FindByEmailAsync(email);

            if (userFromDatabase != null)
            {
                return;
            }

            userFromDatabase = new ApplicationUser
            {
                AccessFailedCount = 0,
                Email = email,
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = email.ToUpper(),
                NormalizedUserName = email.ToUpper(),
                TwoFactorEnabled = false,
                UserName = email
            };

            await userManager.CreateAsync(userFromDatabase, "Test12!!");
            await userManager.AddToRoleAsync(userFromDatabase, role);
        }
    }
}
