using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class ProveedorDto
{
    public int Id { get; set; }
    public string NitProveedor { get; set; }
    public string NombreProveedor { get; set; }
    public int IdTipoPersonaFK { get; set; }
    public int IdMunicipioFk { get; set; }
}
