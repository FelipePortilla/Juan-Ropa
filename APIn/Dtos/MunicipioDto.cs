using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class MunicipioDto
{
    public int Id { get; set; }
    public string NombreMunicipio { get; set; }
    public int IdDepartamentoFk { get; set; }
}
