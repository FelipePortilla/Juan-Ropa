using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("detalleorden");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.CantidadProducir).HasColumnType("int");
        builder.Property(x => x.CantidadProducida).HasColumnType("int");

        builder.HasOne(x => x.Ordenes).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdOrdenFk);
        builder.HasOne(x => x.Prendas).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdPrendaFk);
        builder.HasOne(x => x.Colores).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdColorFk);
        builder.HasOne(x => x.Estados).WithMany(x => x.DetalleOrdenes).HasForeignKey(x => x.IdEstadoFk);
    }
}
