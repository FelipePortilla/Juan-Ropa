using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class VentaConfiguration : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {
        builder.ToTable("venta");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id);

        builder.Property(x=>x.FechaVenta).HasColumnType("date");
        builder.HasOne(x=>x.Empleados).WithMany(x=>x.Ventas).HasForeignKey(x=>x.IdEmpleadoFk);
        builder.HasOne(x=>x.Clientes).WithMany(x=>x.Ventas).HasForeignKey(x=>x.IdClienteFk);
    }
}