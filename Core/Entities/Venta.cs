using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Venta: BaseEntity
    {
       public DateOnly FechaVenta { get; set; }
    public int IdEmpleadoFk { get; set; }
    public Empleado Empleados { get; set; }
    public int IdClienteFk { get; set; }
    public Cliente Clientes { get; set; }
    public int IdFormaPagoFk { get; set; }
    public FormaPago FormaPago { get; set; }
    public ICollection<DetalleVenta> DetalleVentas { get; set; } 
    }
}