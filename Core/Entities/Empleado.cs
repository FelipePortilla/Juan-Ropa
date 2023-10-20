using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empleado:BaseEntity
    {
        public string IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public int IdCargoFk { get; set; }
        public Cargo Cargos { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipios { get; set; }
        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
    }
}