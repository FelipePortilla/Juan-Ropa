using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IUnitOfWork
    {
            IPais Paises {get;}
    Task<int> SaveAsync();
}
    }
