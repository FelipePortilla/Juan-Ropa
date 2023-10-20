using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleOrden:BaseEntity
    {
        public int IdDetalleOrden { get; set; }
        public int IdOrden { get; set; }
        public int Prenda { get; set; }
        public string cantidadProducir { get; set; }
        public int IdColor { get; set; }
        public string cantidadProducida {get; set;}
        public int IdEstado { get; set; }
    }
}