using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class PrendaDto
{
    public int Id { get; set; }
    public int IdPrenda { get; set; }
    public string NombrePrenda { get; set; }
    public double ValorUnitCop { get; set; }
    public double ValorUnitUsd { get; set; }
    public int IdEstadoFk { get; set; }
    public int IdTipoProteccion { get; set; }
    public int IdGeneroFk { get; set; }
}