using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class VentaDto
{
    public int Id { get; set; }
    public DateOnly FechaVenta { get; set; }
    public int IdEmpleadoFk { get; set; }
    public int IdClienteFk { get; set; }
    public int IdFormaPagoFk { get; set; }
}
