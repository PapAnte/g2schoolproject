using Bravo.Data;
using Bravo.Models.DatabaseEntities;
using Bravo.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Services
{
    public interface IToolService : IService<ITool, Tool>
    {

    }

    public class ToolService : IToolService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ToolService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<ITool> Get()
        {
            return _applicationDbContext.Tools;
        }

        public ITool Get(long id)
        {
           return _applicationDbContext.Tools.SingleOrDefault(r => r.Id == id);
        }

        public void Add(Tool tool)
        {
            _applicationDbContext.Tools.Add(tool);
        }

        public async Task SaveChangesAsync()
        {
           await _applicationDbContext.SaveChangesAsync();
        }
    }
}
