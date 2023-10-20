using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cargo :BaseEntity
    {
        public int IdCargo { get; set; }
        public int SueldoBase { get; set; }
    }
}