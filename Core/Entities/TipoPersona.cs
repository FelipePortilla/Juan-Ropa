using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Entities
{
    public class TipoPersona:BaseEntity
    {
        public string NombreTipoPersona { get; set; }

        public ICollection<Proveedor> Proveedors { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}