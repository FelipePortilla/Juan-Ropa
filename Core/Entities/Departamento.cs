using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Departamento :BaseEntity

    {
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public int IdPaisFK { get; set; }
        public ICollection<Municipio> Municipios { get; set; }
    }
}