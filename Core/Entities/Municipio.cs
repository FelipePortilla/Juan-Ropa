using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Municipio :BaseEntity
    {
        public int IdMunicipioFK { get; set; }

        public string NombreMunicipio { get; set; }
        public int IdDepartamento { get; set; }
    }
}