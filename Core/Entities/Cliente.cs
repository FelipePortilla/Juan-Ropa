using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Cliente:BaseEntity
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdTipoPersona { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int IdMunicipio { get; set; }
    }
}