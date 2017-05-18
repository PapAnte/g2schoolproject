using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Services.Abstract
{
    public interface IService<TInterface, UImplementation>
    {
        IEnumerable<TInterface> Get();
        TInterface Get(long id);
        void Add(UImplementation value);
        Task SaveChangesAsync();
    }
}
