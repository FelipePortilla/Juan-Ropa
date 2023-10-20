using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class OrdenDto
{
    public int Id { get; set; }
    public DateOnly Fecha { get; set; }
    public int IdEmpleadoFk { get; set; }
    public int IdClienteFk { get; set; }
    public int IdEstadoFk { get; set; }
}
