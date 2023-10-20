using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InventarioTalla:BaseEntity
    {
        public int Cantidad { get; set; }
        public int IdInvetarioFk { get; set; }
        public Inventario Inventarios { get; set; }    
         public int IdTallaFK { get; set; }
        public Talla Tallas { get; set; }
    }
}