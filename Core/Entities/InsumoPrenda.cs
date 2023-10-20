using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoPrenda : BaseEntity
    {
        public int Cantidad { get; set; }
          public int IdInsumoFk { get; set; }
          public Insumo Insumos { get; set; }
        public int IdPrendaFk { get; set; }
          public Prenda Prendas { get; set; }
    }
}
