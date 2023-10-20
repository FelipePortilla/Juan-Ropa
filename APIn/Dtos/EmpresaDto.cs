using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class EmpresaDto
{
    public int Id { get; set; }
    public int IdEmpleado { get; set; }
    public string NombreEmpleado { get; set; }
    public DateOnly FechaCreacion { get; set; }
    public int IdCargoFK { get; set; }
    public int IdMunicipioFK { get; set; }
}
