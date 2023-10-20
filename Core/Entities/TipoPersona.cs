using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoPersona:BaseEntity
    {
        public int IdTipoPersona { get; set; }
        public string NombreTipoPersona { get; set; }
    }
}