using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Genero:BaseEntity
    {
        public string Descripcion { get; set; }
    public ICollection<Prenda> Prendas { get; set; }
    }
}