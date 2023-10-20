using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Core.Entities
{
    public class Cliente:BaseEntity
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public TipoPersona TipoPersonas { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipios { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}
