using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoEstado
    {
        public string Descripcion { get; set; }
        public string Id {get; set;}

        public ICollection<Estado> Estados { get; set; }
    }
}