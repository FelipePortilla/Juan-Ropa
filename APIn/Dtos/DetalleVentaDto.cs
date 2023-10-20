using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class DetalleVentaDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public double ValorUnit { get; set; }
    public int IdVentaFk { get; set; }
    public int IdInventarioFk { get; set; }
    public int IdTallaFk { get; set; }
}
