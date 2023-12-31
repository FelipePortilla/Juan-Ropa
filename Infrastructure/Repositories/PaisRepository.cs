using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly RopaContexxt _context;

    public PaisRepository(RopaContexxt context) : base(context)
    {
        _context = context;
    }
}
}


/**/