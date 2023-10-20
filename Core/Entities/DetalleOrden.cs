using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleOrden:BaseEntity
    {
    public int CantidadProducir { get; set; }
    public int CantidadProducida { get; set; }
    public int IdOrdenFk { get; set; }
    public Orden Ordenes { get; set; }
    public int IdPrendaFk { get; set; }
    public Prenda Prendas { get; set; }
    public int IdColorFk { get; set; }
    public Color Colores { get; set; }
    public int IdEstadoFk { get; set; }
    public Estado Estados { get; set; }
    }
}