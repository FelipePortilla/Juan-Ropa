using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIn.Dtos;
public class InsumoDto
{
    public int Id { get; set; }
    public string NombreInsumo { get; set; }
    public double ValorUnit { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
}
