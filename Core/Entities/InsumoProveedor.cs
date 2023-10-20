using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoProveedor: BaseEntity
    {
        public int IdInsumoFk { get; set; }
        public Insumo Insumos { get; set; }
        public int IdProveedor { get; set; }
        public Proveedor Proveedores { get; set; }
    }
}