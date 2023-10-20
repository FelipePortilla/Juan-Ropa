using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Interface;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork
    {
        
    }
}

/*: IUnitOfWork, IDisposable
{
    private IPais _paises;
    private readonly RopaContext _context;

    public UnitOfWork(RopaContext context)
    {
        _context = context;
    }
    public IPais Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _paises;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
*/