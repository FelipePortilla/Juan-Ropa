using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Empresa:BaseEntity
    {
        public string Nit { get; set; }
        public string RazonSocial { get; set; }
        public string RepresentanteLegal { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public int IdMunicipioFk { get; set; }
        public Municipio Municipios { get; set; }
    }
}



