using Bravo.Data;
using Bravo.Models.DatabaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Services
{
    public interface IRoomService
    {
        IEnumerable<IRoom> Get();
        IRoom Get(long id);
        void Add(Room room);
        Task SaveChangesAsync();
    }

    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RoomService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<IRoom> Get()
        {
            return _applicationDbContext.Rooms.Include(s => s.RoomToolRelations).ThenInclude(s => s.Tool);
        }

        public IRoom Get(long id)
        {
           return _applicationDbContext.Rooms.Include(s => s.RoomToolRelations).ThenInclude(s => s.Tool).SingleOrDefault(r => r.Id == id);
        }

        public void Add(Room room)
        {
            _applicationDbContext.Rooms.Add(room);
        }

        public async Task SaveChangesAsync()
        {
           await _applicationDbContext.SaveChangesAsync();
        }
    }
}
