using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class ClienteDto
{
    public int Id { get; set; }
    public int IdCliente { get; set; }
    public string NombreCliente { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public int IdMunicipioFK { get; set; }
}