using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    private readonly RopaContexxt _context;

    public DepartamentoRepository(RopaContexxt context) : base(context)
    {
        _context = context;
    }
}