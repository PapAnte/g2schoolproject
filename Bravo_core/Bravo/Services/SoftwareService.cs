using Bravo.Data;
using Bravo.Models.DatabaseEntities;
using Bravo.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Services
{
    public interface ISoftwareService : IService<ISoftware, Software>
    {

    }

    public class SoftwareService : ISoftwareService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SoftwareService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<ISoftware> Get()
        {
            return _applicationDbContext.Software;
        }

        public ISoftware Get(long id)
        {
            return _applicationDbContext.Software.SingleOrDefault(r => r.Id == id);
        }

        public void Add(Software software)
        {
            _applicationDbContext.Software.Add(software);
        }

        public async Task SaveChangesAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}

