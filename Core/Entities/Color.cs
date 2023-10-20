using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Color :BaseEntity
    {
        public int IdColor { get; set; }
        public string Descripcion { get; set; }
    }
}