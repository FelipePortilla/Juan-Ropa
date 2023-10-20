using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class DepartamentoDto
{
    public int Id { get; set; }
    public string NombreDepartamento { get; set; }
    public int IdPaisFk { get; set; }
}
