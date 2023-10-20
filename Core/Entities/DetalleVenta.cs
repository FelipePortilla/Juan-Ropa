using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta:BaseEntity
    {
        
        public int IdVentaFK { get; set; }
        
        public Venta Ventas { get; set; }
        public int IdInventarioFk { get; set; }
        public Inventario Inventarios { get; set; }
        public int IdTallaFk { get; set; }
        public string Cantidad { get; set; }
        public double ValorUnit { get; set; }
        public Talla Tallas { get; set; }

    }
}


